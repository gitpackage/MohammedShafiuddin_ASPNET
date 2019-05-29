/*Program.cs*/

//
// <<your name>>
// U. of Illinois, Chicago
// CS 341, Fall 2018
// Project #06: Netflix database application
// [SOLUTION]
//

using System;
using System.Data;
using System.Data.SqlClient;

namespace program
{

  class Program
  {
    //
    // Connection info for ChicagoCrimes database in Azure SQL:
    //
    static string connectionInfo = String.Format(@"
Server=tcp:jhummel2.database.windows.net,1433;Initial Catalog=Netflix;
Persist Security Info=False;User ID=student;Password=cs341!uic;
MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;
Connection Timeout=30;
");


    // ########################################################################
    //
    // GetMovie(id)
    // 
    // Given a movie id, retrieves and outputs data about that movie.
    // 
    static void GetMovie(int id)
    {
      SqlConnection db = null;

      System.Console.WriteLine();

      try
      {
        db = new SqlConnection(connectionInfo);
        db.Open();

        string sql = string.Format(@"
SELECT *
FROM Movies
WHERE MovieID = {0};
", id);

        //System.Console.WriteLine(sql);  // debugging:

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = db;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        cmd.CommandText = sql;
        adapter.Fill(ds);

        var rows = ds.Tables["TABLE"].Rows;

        if (rows.Count == 0)
        {
          System.Console.WriteLine("** Movie not found...");
        }
        else
        {
          var row = rows[0];

          System.Console.WriteLine("{0}", row["MovieID"]);
          System.Console.WriteLine("'{0}'", row["MovieName"]);
          System.Console.WriteLine("Year: {0}", row["MovieYear"]);

          sql = string.Format(@"
SELECT Count(Rating) As NumReviews, AVG(Convert(Float,Rating)) As AvgRating
FROM Reviews
WHERE MovieID = {0};
", id);

          ds.Clear();

          cmd.CommandText = sql;
          adapter.Fill(ds);

          rows = ds.Tables["TABLE"].Rows;

          if (rows.Count == 0)
          {
            System.Console.WriteLine("Num reviews: 0");
            System.Console.WriteLine("Avg rating: N/A");
          }
          else
          {
            row = rows[0];

            System.Console.WriteLine("Num reviews: {0}", row["NumReviews"]);

            if (System.Convert.ToInt32(row["NumReviews"]) > 0)
              System.Console.WriteLine("Avg rating: {0:0.00000}", row["AvgRating"]);
            else
              System.Console.WriteLine("Avg rating: N/A");
          }
        }//else
      }
      catch (Exception ex)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("**Error in GetMovie(id): {0}", ex.Message);
        System.Console.WriteLine();
      }
      finally
      {
        //
        // success or failure, make sure connection is closed:
        //
        if (db != null && db.State != ConnectionState.Closed)
          db.Close();
      }
    }


    // ########################################################################
    //
    // GetMovie(name)
    // 
    // Given a movie name, retrieves and outputs data about that movie.
    // Since the "name" could be a partial name, this implies it could
    // match multiple movies, e.g. when searching for "Lord".
    // 
    static void GetMovie(string name)
    {
      SqlConnection db = null;

      try
      {
        db = new SqlConnection(connectionInfo);
        db.Open();

        //
        // be sure to escape the string in case it contains ':
        //
        name = name.Replace("'", "''");
        
        //
        // What we're going to do is just retrieve the movie ids,
        // and then we'll call the GetMovie(id) function over and
        // over again to output the data about each movie:
        //
        string sql = string.Format(@"
SELECT MovieID
FROM Movies
WHERE MovieName Like '%{0}%'
ORDER BY MovieName ASC;
", name);

        //System.Console.WriteLine(sql);  // debugging:

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = db;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        cmd.CommandText = sql;
        adapter.Fill(ds);

        var rows = ds.Tables["TABLE"].Rows;

        if (rows.Count == 0)
        {
          System.Console.WriteLine();
          System.Console.WriteLine("** Movie not found...");
        }
        else
        {
          //
          // foreach movie, grab id and call GetMovie(id):
          //
          foreach (DataRow row in rows)
          {
            int id = Convert.ToInt32(row["MovieID"]);

            GetMovie(id);
          }
        }
      }
      catch (Exception ex)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("**Error in GetMovie(name): {0}", ex.Message);
        System.Console.WriteLine();
      }
      finally
      {
        //
        // success or failure, make sure connection is closed:
        //
        if (db != null && db.State != ConnectionState.Closed)
          db.Close();
      }
    }



    // ########################################################################
    // 
    // GetUser(id)
    //
    // Given a user id, retrieves and outputs data about that user (occupation,
    // # of reviews, etc.).  
    //
    static void GetUser(int id)
    {
      SqlConnection db = null;

      System.Console.WriteLine();

      try
      {
        db = new SqlConnection(connectionInfo);
        db.Open();

        string sql = string.Format(@"
SELECT *
FROM Users
WHERE UserID = {0};
", id);

        //System.Console.WriteLine(sql);  // debugging:

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = db;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        cmd.CommandText = sql;
        adapter.Fill(ds);

        var rows = ds.Tables["TABLE"].Rows;

        if (rows.Count == 0)
        {
          System.Console.WriteLine("** User not found...");
        }
        else
        {
          var row = rows[0];

          System.Console.WriteLine("{0}", row["UserName"]);
          System.Console.WriteLine("User id: {0}", row["UserID"]);
          System.Console.WriteLine("Occupation: {0}", row["Occupation"]);

          sql = string.Format(@"
SELECT Count(Rating) As NumReviews, AVG(Convert(Float,Rating)) As AvgRating
FROM Reviews
WHERE UserID = {0};
", id);

          ds.Clear();

          cmd.CommandText = sql;
          adapter.Fill(ds);

          rows = ds.Tables["TABLE"].Rows;

          if (rows.Count == 0)
          {
            System.Console.WriteLine("Avg rating: N/A");
            System.Console.WriteLine("Num reviews: 0");
          }
          else
          {
            row = rows[0];

            if (System.Convert.ToInt32(row["NumReviews"]) == 0)
            {
              System.Console.WriteLine("Avg rating: N/A");
              System.Console.WriteLine("Num reviews: 0");
            }
            else
            {
              System.Console.WriteLine("Avg rating: {0:0.00000}", row["AvgRating"]);
              System.Console.WriteLine("Num reviews: {0}", row["NumReviews"]);

              sql = string.Format(@"
SELECT Rating, Count(*) As NumReviews
FROM Reviews
WHERE UserID = {0}
GROUP BY Rating
ORDER BY Rating ASC;
", id);
              ds.Clear();

              cmd.CommandText = sql;
              adapter.Fill(ds);

              rows = ds.Tables["TABLE"].Rows;

              //
              // NOTE: we want to print out the # of reviews for each star, 
              // but this is tricky because the user may not have given all
              // 5 ratings. So the # of rows might not == 5.
              //
              string unit = "star";
              int cur = 0;  // current index into the data we retrieved:

              for (int stars = 1; stars <= 5; ++stars)
              {
                row = rows[cur];

                int numReviews;

                if (stars > 1)
                  unit = "stars";

                if (stars == System.Convert.ToInt32(row["Rating"]))
                {
                  numReviews = System.Convert.ToInt32(row["NumReviews"]);
                  if (cur < rows.Count - 1)
                    ++cur;
                }
                else
                {
                  numReviews = 0;
                }

                string msg = string.Format(" {0} {1}: {2}",
                  stars,
                  unit,
                  numReviews);

                System.Console.WriteLine(msg);
              }

            }
          }
        }//else
      }
      catch (Exception ex)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("**Error in GetUser(id): {0}", ex.Message);
        System.Console.WriteLine();
      }
      finally
      {
        //
        // success or failure, make sure connection is closed:
        //
        if (db != null && db.State != ConnectionState.Closed)
          db.Close();
      }
    }


    // ########################################################################
    // 
    // GetUser(name)
    //
    // Given user name, retrieves and outputs data about that user (occupation,
    // # of reviews, etc.).  The name must be an exact match (partial matches
    // are not supported).
    //
    static void GetUser(string name)
    {
      SqlConnection db = null;

      try
      {
        db = new SqlConnection(connectionInfo);
        db.Open();

        //
        // be sure to escape the string in case it contains ':
        //
        name = name.Replace("'", "''");

        //
        // We just retrieve the user id, and then call GetUser(id):
        //
        string sql = string.Format(@"
SELECT UserID
FROM Users
WHERE UserName = '{0}';
", name);

        //System.Console.WriteLine(sql);  // debugging:

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = db;
        cmd.CommandText = sql;

        object result = cmd.ExecuteScalar();

        db.Close();

        if (result == null || result == System.DBNull.Value)  // not found or no value:
        {
          System.Console.WriteLine();
          System.Console.WriteLine("** User not found...");
        }
        else
        {
          int id = System.Convert.ToInt32(result);
          GetUser(id);
        }
      }
      catch (Exception ex)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("**Error in GetUser(name): {0}", ex.Message);
        System.Console.WriteLine();
      }
      finally
      {
        //
        // success or failure, make sure connection is closed:
        //
        if (db != null && db.State != ConnectionState.Closed)
          db.Close();
      }
    }


    // ########################################################################
    // 
    // Top10
    //
    // Retrieves and outputs the top-10 movies by average rating.
    //
    static void Top10()
    {
      SqlConnection db = null;

      System.Console.WriteLine();

      try
      {
        db = new SqlConnection(connectionInfo);
        db.Open();

        //
        // Group the reviews by movie id, compute average rating, and sort in
        // descending order:
        //
        string sql = string.Format(@"
SELECT TOP 10 Reviews.MovieID, 
              Count(Rating) As NumReviews, 
              AVG(CONVERT(float,Rating)) As AvgRating, 
              MovieName
FROM Reviews
Inner Join Movies on Reviews.MovieID = Movies.MovieID
Group By Reviews.MovieID, MovieName
Order By AvgRating DESC, MovieName ASC;
");

        //System.Console.WriteLine(sql);  // debugging:

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = db;
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        cmd.CommandText = sql;
        adapter.Fill(ds);

        Console.WriteLine("Rank\tMovieID\tNumReviews\tAvgRating\tMovieName");

        int rank = 1;

        foreach (DataRow row in ds.Tables["TABLE"].Rows)
        {
          string msg = string.Format("{0}\t{1}\t{2}\t\t{3:0.00000}\t\t'{4}'",
            rank,
            Convert.ToInt32(row["MovieID"]),
            Convert.ToInt32(row["NumReviews"]),
            Convert.ToDouble(row["AvgRating"]),
            Convert.ToString(row["MovieName"]));

          System.Console.WriteLine(msg);

          rank++;
        }

      }
      catch (Exception ex)
      {
        System.Console.WriteLine();
        System.Console.WriteLine("**Error in Top10: {0}", ex.Message);
        System.Console.WriteLine();
      }
      finally
      {
        //
        // success or failure, make sure connection is closed:
        //
        if (db != null && db.State != ConnectionState.Closed)
          db.Close();
      }
    }
    
    
    // ########################################################################
    //
    // GetUserCommand:
    //
    // Prompts the user for a command, and returns that command string.
    //
    static string GetUserCommand()
    {
      System.Console.WriteLine();
      System.Console.WriteLine("What would you like?");
      System.Console.WriteLine("m. movie info");
      System.Console.WriteLine("t. top-10 info");
      System.Console.WriteLine("u. user info");
      System.Console.WriteLine("x. exit");
      System.Console.Write(">> ");

      string cmd = System.Console.ReadLine();

      return cmd.ToLower();
    }


    // ########################################################################
    //
    // Main:
    //
    static void Main(string[] args)
    {
      System.Console.WriteLine("** Netflix Database App **");

      string cmd = GetUserCommand();

      while (cmd != "x")
      {
        if (cmd == "m")
        {
          System.Console.Write("Enter movie id or part of movie name>> ");
          string movie = System.Console.ReadLine();

          int id;
          if (System.Int32.TryParse(movie, out id))
          {
            // lookup movie id:
            GetMovie(id);
          }
          else
          {
            // lookup by partial name match:
            GetMovie(movie);
          }
        }
        else if (cmd == "t")
        {
          Top10();
        }
        else if (cmd == "u")
        {
          System.Console.Write("Enter user id or name>> ");
          string user = System.Console.ReadLine();

          int id;
          if (System.Int32.TryParse(user, out id))
          {
            // lookup movie id:
            GetUser(id);
          }
          else
          {
            // lookup by partial name match:
            GetUser(user);
          }
        }
        else
        {
          System.Console.WriteLine("** Invalid command, try again...");
        }

        cmd = GetUserCommand();
      }

      System.Console.WriteLine();
      System.Console.WriteLine("** Done **");
      System.Console.WriteLine();
    }

  }//class
}//namespace


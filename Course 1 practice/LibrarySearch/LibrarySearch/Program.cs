using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibrarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("books.txt");

            #region getN
            int n;
            try
            {
                n = Convert.ToInt32(sr.ReadLine());
            }
            catch (FormatException)
            {
                n = 0;
                throw new Exception("Invalid n");
            }
            catch (Exception)
            {
                n = 0;
                throw new Exception("Smth strange with n!");
            }
            #endregion
           
            Book[] books = new Book[n];

            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                books[i] = createBookFromString(s);
            }

            #region getK
            int k;
            try
            {
                k = Convert.ToInt32(sr.ReadLine());
            }
            catch (FormatException)
            {
                k = 0;
                throw new Exception("Invalid k");
            }
            catch (Exception)
            {
                k = 0;
                throw new Exception("Smth strange with k!");
            }
            #endregion

            StreamWriter sw = new StreamWriter("output.txt");

            for (int i = 0; i < k; i++)
            {
                #region getC
                int c;
                try
                {
                    c = Convert.ToInt32(sr.ReadLine());
                }
                catch (FormatException)
                {
                    c = 0;
                    throw new Exception("Illegal count c request format!");
                }
                catch (Exception)
                {
                    c = 0;
                    throw new Exception("Smth bad with count c request!");
                }
                #endregion

                #region makeRequest
                Book check_book = new Book();
                for (int j = 0; j < c; j++)
                {
                    string s = sr.ReadLine();
                    switch (s[0])
                    {
                        case 'i':
                            try
                            {
                                check_book.Id = Convert.ToInt32(s.Substring(2));
                            }
                            catch (FormatException)
                            {
                                throw new Exception("Illegal id request format!");
                            }
                            catch (Exception)
                            {
                                throw new Exception("Smth bad with id request!");
                            }
                            break;

                        case 't':
                            check_book.Title = s.Substring(2);
                            break;

                        case 'a':
                            check_book.Author = s.Substring(2);
                            break;

                        case 'y':
                            try
                            {
                                check_book.Year = Convert.ToInt32(s.Substring(2));
                            }
                            catch (FormatException)
                            {
                                throw new Exception("Illegal year request format!");
                            }
                            catch (Exception)
                            {
                                throw new Exception("Smth bad with year request!");
                            }
                            break;

                        default:
                            break;
                    }
                }
                #endregion

                sw.WriteLine("Request " + (i + 1) + ":");
                for (int j = 0; j < n; j++)
                {
                    if (books[j].isBooksEqual(check_book))
                        sw.WriteLine(books[j].bookToString());
                }
            }

            sr.Close();
            sw.Close();
        }

        private static Book createBookFromString(String book_description)
        {
            string[] dates = book_description.Split(' ');
            
            #region getId
            int id;
            try
            {
                id = Convert.ToInt32(dates[0]);
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid id!");
            }
            catch (Exception e)
            {
                throw new Exception("Smth strange with id!");
            }
            #endregion

            String title = dates[1];
            String author = dates[2];

            #region getYear
            int year;
            try
            {
                year = Convert.ToInt32(dates[3]);
            }
            catch (FormatException ex)
            {
                throw new Exception("Invalid year!");
            }
            catch (Exception e)
            {
                throw new Exception("Smth strange with year!");
            }
            #endregion

            return new Book(id, title, author, year);
        }
    }
}

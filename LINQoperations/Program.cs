using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQoperations
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Prodcut Review Management!!!!!!!!");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option" +
                              "\n1.Add Values to list" +
                              "\n2.Retrieve Top 3 Records" +
                              "\n3.Retrieve Records Based On Rating and Product Id" +
                              "\n4.Retrived the count of productId" +
                              "\n5.Retrieving the product id in list" +
                              "\n6.Skip Top five records" +
                              "\n7.Retrieving ProductID,Reviews and Adding values to DataTable" +
                              "\n8.retrieve the records whose column islike has true using (DataTable)" +
                              "&&  Finding the average rating value" +
                              "\n9.Retrieve all records with message 'nice' in ProductReview");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review 
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
                case 2:
                    ProductReviewManager.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                case 4:
                    ProductReviewManager.CountingProductId(productReviews);
                    break;
                case 5:
                    ProductReviewManager.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    ProductReviewManager.SkipTopFiveRecords(productReviews);
                    break;
                case 7:
                    ProductReviewManager.AddingProductReview(productReviews);
                    ProductReviewManager.CreateDataTable(productReviews);
                    break;
                case 8:
                    //DataTable dt = new DataTable();
                    //ProductReviewManager.AverageOfRating(dt);
                    //break;
                    ProductReviewManager.ReturnsOnlyIsLikeFieldAsTrue();
                    ProductReviewManager.AverageOfRating();
                    break;
                case 9:
                    ProductReviewManager.ReturnsReviewMessageContainsGood();
                    break;


            }
        }
    }
}
      





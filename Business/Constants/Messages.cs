using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string CarNameInvalid = "Invalid car name. Please try again with valid information.";
        public static string CarDeleted = "Car deleted.";
        public static string CarUpdated = "Car updated.";
        internal static string CarsListed = "Cars listed.";
        public static string CarRented = "Car rented successfully!";
        public static string CarNotAvailable = "The car you selected is not available.";
        public static string UserAdded = "User added successfully!";
        internal static string RentalsListed = "All rentals listed!";
        internal static string CarAlreadyExists = "This car already exists.";
        internal static string CarImageLimitExceeded = "A car can only have 5 images.";
        internal static string CarImageNotFound = "This car doesn't have any images.";
    }
}
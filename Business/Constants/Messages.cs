using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;

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
        internal static string UsersListed = "All users have been listed.";
        internal static string UserDeleted = "User deleted successfully!";
        internal static string UserUpdated = "User updated successfully";
        internal static string? AuthorizationDenied = "Authorization denied!";
        internal static string UserRegistered = "User registered.";
        internal static string UserAlreadyExists = "User already exists";
        internal static string UserNotFound = "User not found";
        internal static string PasswordError = "Wrong password";
        internal static string SuccessfulLogin = "Logged in successfully";
        internal static string AccessTokenCreated = "Access token created successfully";
    }
}
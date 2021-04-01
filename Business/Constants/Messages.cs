using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded="Model Eklendi.";
        internal static string BrandUpdated;
        internal static string BrandDeleted;
        internal static string BrandGetAll;
        internal static string BrandGetById;
        internal static string CarAdded;
        internal static string CarAddedError;
        internal static string CarUpdated;
        internal static string CarDeleted;
        internal static string ColorAdded;
        internal static string ColorUpdated;
        internal static string ColorDeleted;
      
     
        internal static string CustomerAdded;
        internal static string CustomerDeleted;
        internal static string CustomerUpdated;
        
        internal static string RentalAdded;
        internal static string ColorGetAll;
        internal static string ColorGetById;
        internal static string CarGetAll;
        internal static string GetCarsByBrandId;
        internal static string CarGetCarsByColorId;
        internal static string CarGetCarDetail;
        internal static string CustomerGetAll;
        internal static string CustomerGetById;
        internal static string RentalUpdated;
        internal static string RentalDeleted;
        internal static string RentalGetAll;
        internal static string RentalGetById;
        internal static string RentalUpdatedReturnDateError;
        internal static string RentalUpdatedReturnDate;
        internal static string RentalAddedError;
        internal static string FailAddedImageLimit;
        internal static string CarImageDeleted;
        internal static string AuthorizationDenied;
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}

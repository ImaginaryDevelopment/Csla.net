using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Csla;
using Csla.Serialization;

namespace Library.Net
{
    [Serializable]
    public class PersonEdit : BusinessBase<PersonEdit>
    {
        #region Properties

        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        public int Id
        {
            get
            {
                return GetProperty(IdProperty);
            }
            private set
            {
                LoadProperty(IdProperty, value);
            }
        }

        public static readonly PropertyInfo<bool> IsActiveProperty = RegisterProperty<bool>(c => c.IsActive);
        [Display(Name = "Is Active")]
        [Required]
        public bool IsActive
        {
            get
            {
                return GetProperty(IsActiveProperty);
            }
            set
            {
                SetProperty(IsActiveProperty, value);
            }
        }

        public static readonly PropertyInfo<int> RoleIDProperty = RegisterProperty<int>(c => c.RoleID);
        [Required]
        public int RoleID
        {
            get
            {
                return GetProperty(RoleIDProperty);
            }
            set
            {
                SetProperty(RoleIDProperty, value);
            }
        }

        public static readonly PropertyInfo<string> UserNameProperty = RegisterProperty<string>(c => c.UserName);
        [Required]
        [Display(Name = "Username")]
        public string UserName
        {
            get
            {
                return GetProperty(UserNameProperty);
            }
            set
            {
                SetProperty(UserNameProperty, value);
            }
        }

        public static readonly PropertyInfo<string> PasswordProperty = RegisterProperty<string>(c => c.Password);
        [Required]
        public string Password
        {
            get
            {
                return GetProperty(PasswordProperty);
            }
            set
            {
                SetProperty(PasswordProperty, value);
            }
        }

        public static readonly PropertyInfo<string> FirstNameProperty = RegisterProperty<string>(c => c.FirstName);
        [Display(Name = "First Name")]
        [Required]
        public string FirstName
        {
            get
            {
                return GetProperty(FirstNameProperty);
            }
            set
            {
                SetProperty(FirstNameProperty, value);
            }
        }

        public static readonly PropertyInfo<string> MiddleNameProperty = RegisterProperty<string>(c => c.MiddleName);
        [Display(Name = "Middle Name")]
        public string MiddleName
        {
            get
            {
                return GetProperty(MiddleNameProperty);
            }
            set
            {
                SetProperty(MiddleNameProperty, value);
            }
        }

        public static readonly PropertyInfo<string> LastNameProperty = RegisterProperty<string>(c => c.LastName);
        [Display(Name = "Last Name")]
        [Required]
        public string LastName
        {
            get
            {
                return GetProperty(LastNameProperty);
            }
            set
            {
                SetProperty(LastNameProperty, value);
            }
        }

        public static readonly PropertyInfo<DateTime> LastUpdatedProperty = RegisterProperty<DateTime>(c => c.DateLastUpdated);
        [Display(Name = "Last Updated")]
        [Required]
        public DateTime DateLastUpdated
        {
            get
            {
                return GetProperty(LastUpdatedProperty);
            }
            set
            {
                SetProperty(LastUpdatedProperty, value);
            }
        }

        public static readonly PropertyInfo<string> UpdatedByProperty = RegisterProperty<string>(c => c.UpdatedBy);
        [Display(Name = "Updated By")]
        [Required]
        public string UpdatedBy
        {
            get
            {
                return GetProperty(UpdatedByProperty);
            }
            set
            {
                SetProperty(UpdatedByProperty, value);
            }
        }

        #endregion

        #region DataPortal Activities
        public static void NewPerson(EventHandler<DataPortalResult<PersonEdit>> callback)
        {
            DataPortal.BeginCreate<PersonEdit>(callback);
        }

        public static void GetPerson(int id, EventHandler<DataPortalResult<PersonEdit>> callback)
        {
            DataPortal.BeginFetch<PersonEdit>(id, callback);
        }

        //because Silverlight is async only we mark these
#if SILVERLIGHT
        ;
#else
        public static PersonEdit NewPerson()
        {
            return DataPortal.Create<PersonEdit>();
        }

        public static PersonEdit GetPerson(int id)
        {
            return DataPortal.Fetch<PersonEdit>(id);
        }

        public static void DeletePersonEdit(int id)
        {
            DataPortal.Delete<PersonEdit>(id);
        }

        [RunLocal]
        protected override void DataPortal_Create()
        {
            using (BypassPropertyChecks)
            {
                Id = -1;
            }
            base.DataPortal_Create();
        }

        private void DataPortal_Fetch(int id)
        {
            using (var dalManager = DataAccess.DalFactory.GetManager())
            {
                var dal = dalManager.GetProvider<DataAccess.IPersonDAL>();
                var data = dal.Fetch(id);
                using (BypassPropertyChecks)
                {
                    Id = data.ID;
                    IsActive = data.IsActive;
                    RoleID = data.RoleID;
                    UserName = data.UserName;
                    Password = data.Password;
                    FirstName = data.FirstName;
                    MiddleName = data.MiddleName;
                    LastName = data.LastName;
                    DateLastUpdated = data.DateLastUpdated;
                    UpdatedBy = data.UpdatedBy;
                }
            }
        }

        /// <summary>
        /// Remember, we have an update server side smart enough to figure out what to do based on isnew and isdelete!
        /// </summary>
        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            using (var dalManager = DataAccess.DalFactory.GetManager())
            {
                var dal = dalManager.GetProvider<DataAccess.IPersonDAL>();
                using (BypassPropertyChecks)
                {
                    var data = new DataAccess.PersonDTO { ID = Id, IsActive = IsActive, RoleID = RoleID, UserName = UserName, Password = Password, FirstName = FirstName, MiddleName = MiddleName, LastName = LastName, DateLastUpdated = DateLastUpdated, UpdatedBy = UpdatedBy, IsDeleted = IsDeleted, IsNew = IsNew };
                    dal.Update(data);
                    //deal with the new PK
                    Id = data.ID;
                }
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            using (var dalManager = DataAccess.DalFactory.GetManager())
            {
                var dal = dalManager.GetProvider<DataAccess.IPersonDAL>();
                using (BypassPropertyChecks)
                {
                    var data = new DataAccess.PersonDTO { ID = Id, IsActive = IsActive, RoleID = RoleID, UserName = UserName, Password = Password, FirstName = FirstName, MiddleName = MiddleName, LastName = LastName, DateLastUpdated = DateLastUpdated, UpdatedBy = UpdatedBy, IsDeleted = IsDeleted, IsNew = IsNew };
                    dal.Update(data);
                }
            }
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_DeleteSelf()
        {
            using (BypassPropertyChecks)
            {
                DataPortal_Delete(Id);
            }
        }

        /// <summary>
        /// Remember, we don't really delete people we deactivate them.  the pk, isdelete, and isnew are all that is wire important
        /// </summary>
        /// <param name="id"></param>
        [Transactional(TransactionalTypes.TransactionScope)]
        private void DataPortal_Delete(int id)
        {
            using (var dalManager = DataAccess.DalFactory.GetManager())
            {
                var dal = dalManager.GetProvider<DataAccess.IPersonDAL>();
                dal.Update(new DataAccess.PersonDTO { ID = Id, IsDeleted = true, IsNew = false });
            }
        }

#endif
        protected override void DataPortal_OnDataPortalInvoke(DataPortalEventArgs e)
        {
            // implement your behavior here
            base.DataPortal_OnDataPortalInvoke(e);
        }

        protected override void DataPortal_OnDataPortalInvokeComplete(DataPortalEventArgs e)
        {
            // implement your behavior here
            base.DataPortal_OnDataPortalInvokeComplete(e);
        }

        protected override void Child_OnDataPortalException(DataPortalEventArgs e, Exception ex)
        {
            // implement your behavior here
            base.Child_OnDataPortalException(e, ex);
        }
        #endregion
    }    
}

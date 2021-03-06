﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Inserting(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Inserted(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Updating(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Updated(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Deleting(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Deleted(global::LightSwitchApplication.Task entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Validate(global::LightSwitchApplication.Task entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Tasks_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Task, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Inserting(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Inserted(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Updating(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Updated(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Deleting(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Deleted(global::LightSwitchApplication.User entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Validate(global::LightSwitchApplication.User entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Users_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.User, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ApplicationData_InitializingConnection(global::Microsoft.LightSwitch.DatabaseConnectionState state);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Task>
                __TasksEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Task>(
                    "Tasks",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Tasks_Filter);
            private static bool __Tasks_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Tasks_CanInsert(ref result);
                return result;
            }
            private static bool __Tasks_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Tasks_CanUpdate(ref result);
                return result;
            }
            private static bool __Tasks_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Tasks_CanDelete(ref result);
                return result;
            }
            private static bool __Tasks_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Tasks_CanRead(ref result);
                return result;
            }
            private static void __Tasks_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Inserting(e);
            }
            private static void __Tasks_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Inserted(e);
            }
            private static void __Tasks_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Updating(e);
            }
            private static void __Tasks_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Updated(e);
            }
            private static void __Tasks_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Deleting(e);
            }
            private static void __Tasks_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e)
            {
                d.Tasks_Deleted(e);
            }
            private static void __Tasks_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Task e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Tasks_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Task, bool>> __Tasks_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Task, bool>> filter = null;
                d.Tasks_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.User>
                __UsersEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.User>(
                    "Users",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Users_Filter);
            private static bool __Users_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Users_CanInsert(ref result);
                return result;
            }
            private static bool __Users_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Users_CanUpdate(ref result);
                return result;
            }
            private static bool __Users_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Users_CanDelete(ref result);
                return result;
            }
            private static bool __Users_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Users_CanRead(ref result);
                return result;
            }
            private static void __Users_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Inserting(e);
            }
            private static void __Users_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Inserted(e);
            }
            private static void __Users_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Updating(e);
            }
            private static void __Users_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Updated(e);
            }
            private static void __Users_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Deleting(e);
            }
            private static void __Users_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e)
            {
                d.Users_Deleted(e);
            }
            private static void __Users_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.User e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Users_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.User, bool>> __Users_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.User, bool>> filter = null;
                d.Users_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
    
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.DatabaseAuthEntry<global::LightSwitchApplication.ApplicationDataService>
                ___DatabaseAuthEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.DatabaseAuthEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ApplicationData_InitializingConnection);
            private static void __ApplicationData_InitializingConnection(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.DatabaseConnectionState state)
            {
                d.ApplicationData_InitializingConnection(state);
            }
        }
    
        #endregion
    }
    
    #endregion
}

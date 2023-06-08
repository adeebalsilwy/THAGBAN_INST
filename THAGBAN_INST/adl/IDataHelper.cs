using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace THAGBAN_INST
{
    public interface IDataHelper<Table>
    {
        // Read
        /// <summary>Gets all data.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search item.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Searched Data</returns>
        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table When Id ==Id</returns>

        // Write
        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Add(Table table);
        /// <summary>Edits the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Edit(Table table);
        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 when the task success, 0 when task failed</returns>
        int Delete(int Id);

        // Read Async
        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>All Data Of Table</returns>
        Task<List<Table>> GetAllDataAsync();
        /// <summary>Searches the asynchronous.</summary>
        /// <param name="SearchItem">The search item.</param>
        /// <returns>Row Data</returns>
        /// <summary>Finds the asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Data</returns>
        Task<Table> FindAsync(int Id);

        // Write Async
        
    }
}

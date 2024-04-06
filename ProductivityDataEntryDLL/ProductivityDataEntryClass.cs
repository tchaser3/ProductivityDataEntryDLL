/* Title:           Productivity Data Entry Class
 * Date:            6-1-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the productivity data entry class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ProductivityDataEntryDLL
{
    public class ProductivityDataEntryClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ProductivityDataEntryDataSet aProductivityDataEntryDataSet;
        ProductivityDataEntryDataSetTableAdapters.productivitydataentryTableAdapter aProductivityDataEntryTableAdapter;

        InsertProductivtyDataEntryTableAdapters.QueriesTableAdapter aInsertProductivityDataEntryTableAdapter;

        UpdateProductivityDataEntryHoursTasksEntryTableAdapters.QueriesTableAdapter aUpdateProductivityDataEntryHoursTasksTableAdapter;

        FindProductivityDataEntryByDateDataSet aFindProductivityDataEntryByDateDataSet;
        FindProductivityDataEntryByDateDataSetTableAdapters.FindProductivtyDataEntryByDateTableAdapter aFindProductivityDataEntryByDateTableAdapter;

        FindProductivityDataEntryByDateRangeDataSet aFindProductivityDataEntryByDateRangeDataSet;
        FindProductivityDataEntryByDateRangeDataSetTableAdapters.FindProductivityDataEntryByDateRangeTableAdapter aFindProductivityDataEntryByDateRangeTableAdapter;

        FindProductivityDataEntryByEmployeeIDDataSet aFindProductivityDataEntryByEmployeeIDDataSet;
        FindProductivityDataEntryByEmployeeIDDataSetTableAdapters.FindProductivityDataEntryByEmployeeIDTableAdapter aFindProductivityDataEntryByEmployeeIDTableAdapter;

        FindProductivityDataEntryByProjectIDDataSet aFindProductivityDataEntryByProjectIDDataSet;
        FindProductivityDataEntryByProjectIDDataSetTableAdapters.FindProductivityDataEntryByProjectIDTableAdapter aFindProductivityDataEntryByProjectIDTableAdapter;

        public FindProductivityDataEntryByProjectIDDataSet FindProductivityDataEntryByProjectID(int intProjectID)
        {
            try
            {
                aFindProductivityDataEntryByProjectIDDataSet = new FindProductivityDataEntryByProjectIDDataSet();
                aFindProductivityDataEntryByProjectIDTableAdapter = new FindProductivityDataEntryByProjectIDDataSetTableAdapters.FindProductivityDataEntryByProjectIDTableAdapter();
                aFindProductivityDataEntryByProjectIDTableAdapter.Fill(aFindProductivityDataEntryByProjectIDDataSet.FindProductivityDataEntryByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Find Productivity Data Entry By Project ID " + Ex.Message);
            }

            return aFindProductivityDataEntryByProjectIDDataSet;
        }
        public FindProductivityDataEntryByEmployeeIDDataSet FindProductivityDataEntryByEmployeeID(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductivityDataEntryByEmployeeIDDataSet = new FindProductivityDataEntryByEmployeeIDDataSet();
                aFindProductivityDataEntryByEmployeeIDTableAdapter = new FindProductivityDataEntryByEmployeeIDDataSetTableAdapters.FindProductivityDataEntryByEmployeeIDTableAdapter();
                aFindProductivityDataEntryByEmployeeIDTableAdapter.Fill(aFindProductivityDataEntryByEmployeeIDDataSet.FindProductivityDataEntryByEmployeeID, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception eX)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Find Productivity Data Entry by Employee ID " + eX.Message);
            }

            return aFindProductivityDataEntryByEmployeeIDDataSet;
        }
        public FindProductivityDataEntryByDateRangeDataSet FindProductivityDataEntbyDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductivityDataEntryByDateRangeDataSet = new FindProductivityDataEntryByDateRangeDataSet();
                aFindProductivityDataEntryByDateRangeTableAdapter = new FindProductivityDataEntryByDateRangeDataSetTableAdapters.FindProductivityDataEntryByDateRangeTableAdapter();
                aFindProductivityDataEntryByDateRangeTableAdapter.Fill(aFindProductivityDataEntryByDateRangeDataSet.FindProductivityDataEntryByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Date Entry Class // Find Productivity Date Entry By Date Range " + Ex.Message);
            }

            return aFindProductivityDataEntryByDateRangeDataSet;
        }
        public FindProductivityDataEntryByDateDataSet FindProductivityDataEntryByDate(DateTime datTransactionDate)
        {
            try
            {
                aFindProductivityDataEntryByDateDataSet = new FindProductivityDataEntryByDateDataSet();
                aFindProductivityDataEntryByDateTableAdapter = new FindProductivityDataEntryByDateDataSetTableAdapters.FindProductivtyDataEntryByDateTableAdapter();
                aFindProductivityDataEntryByDateTableAdapter.Fill(aFindProductivityDataEntryByDateDataSet.FindProductivtyDataEntryByDate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Find Proctivity Data Entry By Date " + Ex.Message);
            }

            return aFindProductivityDataEntryByDateDataSet;
        }
        public bool UpdateProductivityDataEntryHoursTasks(int intTransactionID, int intNumberOfHours, int intNumberOfTasks)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductivityDataEntryHoursTasksTableAdapter = new UpdateProductivityDataEntryHoursTasksEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductivityDataEntryHoursTasksTableAdapter.UpdateProductivityDataEntryHoursTasks(intTransactionID, intNumberOfHours, intNumberOfTasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Update Productivity Data Entry Hours " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductivityDataEntry(int intEmployeeID, int intProjectID, DateTime datEntryDate, decimal decProjectHours, int intNumberOfEmployees, int intNumberOfTasks)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductivityDataEntryTableAdapter = new InsertProductivtyDataEntryTableAdapters.QueriesTableAdapter();
                aInsertProductivityDataEntryTableAdapter.InsertProductivityDataEntryItem(intEmployeeID, intProjectID, datEntryDate, decProjectHours, intNumberOfEmployees, intNumberOfTasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Insert Productivity Data Entry " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductivityDataEntryDataSet GetProductivityDataEntryInfo()
        {
            try
            {
                aProductivityDataEntryDataSet = new ProductivityDataEntryDataSet();
                aProductivityDataEntryTableAdapter = new ProductivityDataEntryDataSetTableAdapters.productivitydataentryTableAdapter();
                aProductivityDataEntryTableAdapter.Fill(aProductivityDataEntryDataSet.productivitydataentry);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Get Productivity Data Entry Info " + Ex.Message);
            }

            return aProductivityDataEntryDataSet;
        }
        public void UpdateProductivityDataEntryDB(ProductivityDataEntryDataSet aProductivityDataEntryDataSet)
        {
            try
            {
                aProductivityDataEntryTableAdapter = new ProductivityDataEntryDataSetTableAdapters.productivitydataentryTableAdapter();
                aProductivityDataEntryTableAdapter.Update(aProductivityDataEntryDataSet.productivitydataentry);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Productivity Data Entry Class // Update Productivity Data Entry DB " + Ex.Message);
            }
        }
    }
}

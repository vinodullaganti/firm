
import React, { useState, useEffect }  from 'react';
import { Helmet } from "react-helmet";
import { Link } from 'react-router-dom';
import { httpGet } from "../../../services/apiService";
import { formatHoliday, getCurrentYear, getDay } from '../../../services/dateService';
import holidayApi from './holidayApi';

const Holidays = () => {
  const currentYear = getCurrentYear();
  const [data, setData] = useState([]);

  const retrieveHolidays = () => {
    holidayApi.getHolidays()
      .then(response => {
        setData(response.data);
        console.log("Holidays response Data::",response.data);
      })
      .catch(e => {
        console.log(e);
      });
  };

  useEffect(() => {
    retrieveHolidays();
}, [])
    
  return (
    <div className="page-wrapper"> 
    <Helmet>
        <title>Holidays - HRMS Admin Template</title>
        <meta name="description" content="Login page"/>					
    </Helmet>
    {/* Page Content */}
    <div className="content container-fluid">
      {/* Page Header */}
      <div className="page-header">
        <div className="row align-items-center">
          <div className="col">
            <h3 className="page-title">Holidays {currentYear}</h3>
            <ul className="breadcrumb">
              <li className="breadcrumb-item"><Link to="/app/main/dashboard">Dashboard</Link></li>
              <li className="breadcrumb-item active">Holidays</li>
            </ul>
          </div>
          {/* <div className="col-auto float-right ml-auto">
            <a href="#" className="btn add-btn" data-toggle="modal" data-target="#add_holiday"><i className="fa fa-plus" /> Add Holiday</a>
          </div> */}
        </div>
      </div>
      {/* /Page Header */}
      <div className="row">
        <div className="col-md-12">
          <div className="table-responsive">
            <table className="table table-striped custom-table mb-0">
              <thead>
                <tr>
                  <th>#</th>
                  <th>Title </th>
                  <th>Day</th>
                  <th>Holiday Date</th>
                  <th>Country</th>
                  {/* <th className="text-right">Action</th> */}
                </tr>
              </thead>
              <tbody>
                {data.map((holiday, index)=>(
                  // <tr className="holiday-completed">
                  <tr>
                    <td>{index + 1}</td>
                    <td>{holiday.holidayName}</td>
                    <td>{holiday?.holidayDay}</td>
                    <td>{formatHoliday(holiday?.holidayDate)}</td>
                    <td>{holiday?.location}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
    {/* /Page Content */}
    {/* Add Holiday Modal */}
    <div className="modal custom-modal fade" id="add_holiday" role="dialog">
      <div className="modal-dialog modal-dialog-centered" role="document">
        <div className="modal-content">
          <div className="modal-header">
            <h5 className="modal-title">Add Holiday</h5>
            <button type="button" className="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">×</span>
            </button>
          </div>
          <div className="modal-body">
            <form>
              <div className="form-group">
                <label>Holiday Name <span className="text-danger">*</span></label>
                <input className="form-control" type="text" />
              </div>
              <div className="form-group">
                <label>Holiday Date <span className="text-danger">*</span></label>
                <div><input className="form-control datetimepicker" type="date" /></div>
              </div>
              <div className="submit-section">
                <button className="btn btn-primary submit-btn">Submit</button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
    {/* /Add Holiday Modal */}
    {/* Edit Holiday Modal */}
    <div className="modal custom-modal fade" id="edit_holiday" role="dialog">
      <div className="modal-dialog modal-dialog-centered" role="document">
        <div className="modal-content">
          <div className="modal-header">
            <h5 className="modal-title">Edit Holiday</h5>
            <button type="button" className="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">×</span>
            </button>
          </div>
          <div className="modal-body">
            <form>
              <div className="form-group">
                <label>Holiday Name <span className="text-danger">*</span></label>
                <input className="form-control" defaultValue="New Year" type="text" />
              </div>
              <div className="form-group">
                <label>Holiday Date <span className="text-danger">*</span></label>
                <div><input className="form-control datetimepicker" defaultValue="01-01-2019" type="date" /></div>
              </div>
              <div className="submit-section">
                <button className="btn btn-primary submit-btn">Save</button>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
    {/* /Edit Holiday Modal */}
    {/* Delete Holiday Modal */}
    <div className="modal custom-modal fade" id="delete_holiday" role="dialog">
      <div className="modal-dialog modal-dialog-centered">
        <div className="modal-content">
          <div className="modal-body">
            <div className="form-header">
              <h3>Delete Holiday</h3>
              <p>Are you sure want to delete?</p>
            </div>
            <div className="modal-btn delete-action">
              <div className="row">
                <div className="col-6">
                  <a href="" className="btn btn-primary continue-btn">Delete</a>
                </div>
                <div className="col-6">
                  <a href="" data-dismiss="modal" className="btn btn-primary cancel-btn">Cancel</a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    {/* /Delete Holiday Modal */}
    </div>
  );
}

export default Holidays;

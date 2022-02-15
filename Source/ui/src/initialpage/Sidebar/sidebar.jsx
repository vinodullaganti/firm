/**
 * App Header
 */
 import React from 'react';
 import { withRouter } from 'react-router-dom';
 import { Link } from 'react-router-dom';
 
 const Sidebar = (props) => {
     let pathname = props.location.pathname
     return (
         <div className="sidebar" id="sidebar">
         <div className="sidebar-inner slimscroll">
           <div id="sidebar-menu" className="sidebar-menu">
             <ul>
               <li className="menu-title"> 
                 <span>Main</span>
               </li>
               <li className="submenu">
                 <a href="#"><i className="la la-dashboard" /> <span> Dashboard</span> <span className="menu-arrow" /></a>
                 <ul style={{display: 'none'}}>
                   <li><Link className={pathname.includes('main/dashboard') ?"active" :""} to="/app/main/dashboard">Admin Dashboard</Link></li>
                   <li><Link className={pathname.includes('main/employee-') ?"active" :""} 
                         to="/app/main/employee-dashboard">Employee Dashboard</Link></li>
                 </ul>
               </li>
               <li className="menu-title"> 
                 <span>Employees</span>
               </li>
               <li className="submenu">
                 <a href="#" className="noti-dot"><i className="la la-user" /> <span> Employees</span> <span className="menu-arrow" /></a>
                 <ul style={{display: 'none'}}>
                   <li><Link className={pathname.includes('allemployees') ?"active" :pathname.includes('employees-list') ?"active" :""} 
                         to="/app/employee/allemployees">All Employees</Link></li>
                   <li><Link className={pathname.includes('holidays') ?"active" :""} to="/app/employee/holidays">Holidays</Link></li>
                   <li><Link className={pathname.includes('es-admin') ?"active" :""} to="/app/employee/leaves-admin">Leaves (Admin) <span className="badge badge-pill bg-primary float-right">1</span></Link></li>
                   <li><Link className={pathname.includes('ves-employee') ?"active" :""} to="/app/employee/leaves-employee">Leaves (Employee)</Link></li>
                   <li><Link className={pathname.includes('e-settings') ?"active" :""} to="/app/employee/leave-settings">Leave Settings</Link></li>
                   <li><Link className={pathname.includes('nce-admin') ?"active" :""} to="/app/employee/attendance-admin">Attendance (Admin)</Link></li>
                   <li><Link className={pathname.includes('ce-employee') ?"active" :""} to="/app/employee/attendance-employee">Attendance (Employee)</Link></li>
                   <li><Link className={pathname.includes('departments') ?"active" :""} to="/app/employee/departments">Departments</Link></li>
                   <li><Link className={pathname.includes('designations') ?"active" :""} to="/app/employee/designations">Designations</Link></li>
                   <li><Link className={pathname.includes('timesheet') ?"active" :""} to="/app/employee/timesheet">Timesheet</Link></li>
                   <li><Link className={pathname.includes('shift-scheduling') || pathname.includes('shift-list') ?"active" :""} 
                         to="/app/employee/shift-scheduling">Shift &amp; Schedule</Link></li>
                   <li><Link className={pathname.includes('overtime') ?"active" :""} to="/app/employee/overtime">Overtime</Link></li>
                 </ul>
               </li>
               <li className={pathname.includes('clients') ?"active" :""}> 
                 <Link to = "/app/employees/clients"><i className="la la-users" /> <span>Clients</span></Link>
               </li>
               <li className="submenu">
                 <a href="#"><i className="la la-rocket" /> <span> Projects</span> <span className="menu-arrow" /></a>
                 <ul style={{display: 'none'}}>
                   <li><Link className={pathname.includes('t_dashboard' ) ?"active" : pathname.includes('projects-list' ) ?
                   "active" : pathname.includes('cts-view' ) ? "active" : ""} 
                       to="/app/projects/project_dashboard">Projects</Link></li>
                   <li><Link onClick={()=>localStorage.setItem("minheight","true")} to = "/tasks/tasks">Tasks</Link></li>
                   <li><Link className={pathname.includes('task-board') ?"active" :""} to="/app/projects/task-board">Task Board</Link></li>
                 </ul>
               </li>
               <li className="menu-title"> 
                 <span>HR</span>
               </li>
               <li className="submenu">
                 <a href="#"><i className="la la-pie-chart" /> <span> Reports </span> <span className="menu-arrow" /></a>
                 <ul style={{display: 'none'}}>
                   <li><Link className={pathname.includes('expense-') ?"active" :""} to="/app/reports/expense-reports"> Expense Report </Link></li>
                   <li><Link className={pathname.includes('invoice-') ?"active" :""} to="/app/reports/invoice-reports"> Invoice Report </Link></li>
                   <li><Link className={pathname.includes('payments-') ?"active" :""} to="/app/reports/payments-reports"> Payments Report </Link></li>
                   <li><Link className={pathname.includes('project-') ?"active" :""} to="/app/reports/project-reports"> Project Report </Link></li>
                   <li><Link className={pathname.includes('task-') ?"active" :""} to="/app/reports/task-reports"> Task Report </Link></li>
                   <li><Link className={pathname.includes('user-') ?"active" :""} to="/app/reports/user-reports"> User Report </Link></li>
                   <li><Link className={pathname.includes('employee-') ?"active" :""} to="/app/reports/employee-reports"> Employee Report </Link></li>
                   <li><Link className={pathname.includes('payslip-') ?"active" :""} to="/app/reports/payslip-reports"> Payslip Report </Link></li>
                   <li><Link className={pathname.includes('attendance-') ?"active" :""} to="/app/reports/attendance-reports"> Attendance Report </Link></li>
                   <li><Link className={pathname.includes('leave-') ?"active" :""} to="/app/reports/leave-reports"> Leave Report </Link></li>
                   <li><Link className={pathname.includes('daily-') ?"active" :""} to="/app/reports/daily-reports"> Daily Report </Link></li>
                 </ul>
               </li>
             </ul>
           </div>
         </div>
       </div>
        
       );
    
 }
 
 export default withRouter(Sidebar);
 
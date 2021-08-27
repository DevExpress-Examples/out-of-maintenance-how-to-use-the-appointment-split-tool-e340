<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636404/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T926888)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to use the Appointment Split tool


<p>This example illustrates the use of a new tool allowing end-users to split an appointment in two by simply dragging a splitter line. <br />
To accomplish this, use the <strong>DevExpress.XtraScheduler.Commands.SplitAppointmentOperationCommand</strong> class. Associate this command with the popup menu item in the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.SchedulerControl.PreparePopupMenu">PreparePopupMenu</a> event handler using the <strong>SchedulerMenuItemCommandWinAdapter</strong>. After that all you have to do is select the Split command from the appointment's context menu, drag the splitter to the required time and click the left mouse button. You can use the mouse wheel to adjust the splitter precision.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/K18126">How to use an appointment split tool</a></p>

<br/>



﻿' Developer Express Code Central Example:
' How to use the Appointment Split tool
' 
' This example illustrates the use of a new tool allowing end-users to split an
' appointment in two by simply dragging a splitter line. To accomplish this, use
' the DevExpress.XtraScheduler.Commands.SplitAppointmentOperationCommand class.
' Associate this command with the popup menu item in the PreparePopupMenu
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraSchedulerSchedulerControl_PreparePopupMenutopic)
' event handler using the SchedulerMenuItemCommandWinAdapter. After that all you
' have to do is select the Split command from the appointment's context menu, drag
' the splitter to the required time and click the left mouse button. You can use
' the mouse wheel to adjust the splitter precision.
' See
' Also:
' http://www.devexpress.com/scid=K18126
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E340

Imports System
Imports DevExpress.Xpo

Namespace DevExpress.XtraScheduler.Examples
    ' XP object
    Public Class XPAppointment
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public AllDay As Boolean ' Appointment.AllDay

        <Size(SizeAttribute.Unlimited)> _
        Public Description As String ' Appointment.Description -  !!! To set the Memo field type.

        Public Finish As Date ' Appointment.End
        Public Label As Integer ' Appointment.Label
        Public Location As String ' Appointment.Location

        <Size(SizeAttribute.Unlimited)> _
        Public Recurrence As String ' Appointment.RecurrenceInfo -  !!! To set the Memo field type.

        <Size(SizeAttribute.Unlimited)> _
        Public Reminder As String ' Appointment.ReminderInfo -  !!! To set the Memo field type.

        Public Start As Date ' Appointment.Start
        Public Status As Integer ' Appointment.Status
        <Size(SizeAttribute.Unlimited)> _
        Public Subject As String ' Appointment.Subject -  !!! To set the Memo field type.
        Public AppointmentType As Integer ' Appointment.Type

        Public Resource As XPResource
    End Class

    ' XP object
    Public Class XPResource
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        <Size(SizeAttribute.Unlimited)> _
        Public Name As String ' Resource.Caption -  !!! To set the Memo field type.

        'int Color;
        'Color Color;

        '[Size(SizeAttribute.Unlimited)]
        'Image Picture;
    End Class
End Namespace

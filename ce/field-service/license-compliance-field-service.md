---
title: Objects validated by the solution checker
description: Discover the rules in the Power Apps solution checker that identify tables, operations, and UI components requiring a Dynamics 365 license.
author: vhorvathms
ms.author: vhorvath
ms.reviewer: puneet-singh1
ms.topic: article
ms.collection: get-started
ms.date: 08/27/2025
---

# Objects validated by the solution checker

The Power Apps solution checker identifies tables, operations, and UI components that require a Dynamics 365 license. Use the following lists to understand which objects it validates for a Dynamics 365 Field Service license. Learn more in [licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).  

The lists are subject to change as we add more tables, operations, and controls to the licensed usage list.

## Tables that require a license

To create, update, and delete operations on the following tables, a qualified Dynamics 365 license is required. Reading from these tables doesn't require a license. When you run the solution checker on your solution, it checks for the presence of restricted tables.

- msdyn_purchaseorder
- msdyn_purchaseorderreceipt
- msdyn_inventorytransfer
- msdyn_inventoryadjustment
- msdyn_purchaseorderbill
- msdyn_rma
- msdyn_rmareceipt
- msdyn_rtv
- msdyn_inventoryadjustment
- msdyn_inventoryadjustmentproduct
- msdyn_inventoryjournal
- msdyn_inventorytransfer
- msdyn_rmaproduct
- msdyn_rmareceiptproduct
- msdyn_rmasubstatus
- msdyn_rtvproduct
- msdyn_rtvsubstatus
- msdyn_workorder
- msdyn_workorderservicetask
- msdyn_workorderproduct
- msdyn_workorderservice
- msdyn_workorderservicetask
- msdyn_agreement
- msdyn_agreementbookingsetup
- msdyn_agreementinvoicesetup
- msdyn_agreementbookingdate
- msdyn_agreementinvoicedate
- msdyn_customerasset
- BookableResourceBooking
- BookableResource  
- msdyn_timeoffrequest

## Controls that require a license

The following controls require a Dynamics 365 Field Service license. The solution checker reviews your solutions to identify if these controls are used on forms and shows a message about restricted control usage.  

- msdyn_MscrmControls.BookingStatusControl.BookingStatusControl
- msdyn_MscrmControls.FieldService.NotToExceed
- msdyn_MscrmControls.OrganizationSettingControl.OrganizationSettingControl
- msdyn_MscrmControls.InspectionControls.SurveyCreatorControl
- msdyn_MscrmControls.FieldService.FLWEmailCheckboxControl
- msdyn_MscrmControls.ServiceOperations.ProductCreate
- msdyn_MscrmControls.ServiceOperations.ServiceCreate
- msdyn_FS.ServiceTaskCreate
- msdyn_MscrmControls.TreeView.TreeViewControl
- msdyn_MscrmControls.ServiceView.ServiceView
- msdyn_MscrmControls.ReportPreview
- msdyn_MscrmControls.FieldService.MultiselectLookupControl
- msdyn_FieldService.BookingCard
- msdyn_FieldService.CustomerContactCard
- msdyn_FieldService.DropdownPriority
- msdyn_FieldService.DropdownSystemStatus
- msdyn_FieldService.LineItemsTabSummaryCard
- msdyn_FieldService.LineItemsTabTable
- msdyn_FieldService.LocationCard
- msdyn_FieldService.ReferenceDisplay
- msdyn_FieldService.TasksAtAGlanceCard
- msdyn_FieldService.TasksGrid
- msdyn_FieldService.TimelineNotes
- msdyn_FieldService.WorkOrderAssetTree
- msdyn_FieldService.WorkOrderList
- msdyn_FieldService.CopilotSummary
- msdyn_MscrmControls.BookingControl.BookingControl
- msdyn_MscrmControls.FieldService.MarginAmount
- msdyn_MscrmControls.ProductView.ProductView
- QuicksNotesControl
- msdyn_MscrmControls.ServiceTaskView.ServiceTaskView
- msdyn_MscrmControls.InspectionControls.SurveyControl
- MscrmControls.RequirementGroupControl.RequirementGroupControl
- InFormSchedulingControl

## APIs that require a license

The following APIs require a qualified Dynamics 365 license. The solution checker verifies if these APIs are used when you run it on your solutions.

- msdyn_CascadeBookingChanges
- msdyn_SelectNotToExceed
- msdyn_TradeCoverageNotification
- msdyn_SearchResourceAvailability
- msdyn_SearchResourceAvailabilityForRequirementGroup
- msdyn_CreateRequirementGroupBooking

## See also

- [License compliance overview](license-compliance-overview.md)
- [Use solution checker to validate your solutions](/power-apps/maker/data-platform/use-powerapps-checker)
- [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
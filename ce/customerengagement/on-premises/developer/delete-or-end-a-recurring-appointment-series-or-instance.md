---
title: "Delete or end a recurring appointment series or instance | MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - deleting a recurring appointment series or instance
  - schedule and appointment entities, recurring appointment instances or series
  - ending a recurring appointment series after a specified date
  - recurring appointment instances, deleting or ending
  - schedule and appointment entities, deleting or ending a recurring appointment series or instance
ms.assetid: c07ed908-effe-404b-9925-467b31a29766
caps.latest.revision: 18
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Delete or end a recurring appointment series or instance

You can delete a recurring appointment series, delete an instance in the series, or end a recurring appointment series after a specified date and time.  
  
<a name="bkmk_deleteinstance"></a>   
## Delete a recurring appointment instance  
 Because recurring appointment instances are stored as appointment objects, you can use the<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> on an appointment record to delete a recurring appointment instance. Deleting an appointment instance marks it as an exception by creating an entry for the instance in the `RecurringAppointmentMaster.DeletedExceptionsList` attribute for the parent appointment series object. This is done to track the deleted instance for later synchronization with [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)].  
  
<a name="bkmk_deleteseries"></a>   
## Delete a recurring appointment series  
 You can use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method or the <xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> on a `RecurringAppointmentMaster` record to delete a recurring appointment series. Deleting a series deletes the record and all of the associated recurring appointment instances.  
  
<a name="bkmk_endseries"></a>   
## End a recurring appointment series  
 If you want to end a series before the original end date specified during the creation of the series, you can use the <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest> class. Using this message does the following:  
  
- Deletes all the “open” and “scheduled” future instances of the specified series from the date specified in the <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest.SeriesEndDate> property. However, if the state of the future instances is changed to “completed” or “canceled”, they are not deleted.  
  
- Sets the status of the past instances to the specified value in the <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest.StateOfPastInstances> property. However, the past instances are not deleted.  
  
- Terminates the series to the last occurring past instance date with respect to the date specified in the <xref:Microsoft.Crm.Sdk.Messages.DeleteOpenInstancesRequest.SeriesEndDate> property, and sets the state of the series to “canceled”.  
  
  This allows you to preserve the instances of a recurring appointment series even if you have decided to end it prematurely. This is useful if you have attached notes or attachments to past instances of a recurring appointment series that contain important information about the customer or business.  
  
### See also  
 [Recurring Appointment Entities](recurring-appointment-entities.md)   
 [Link custom attributes of the recurring appointment master and appointment entities](link-custom-attributes-recurring-master-appointment-entities.md)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a Recurring Appointment](sample-create-retrieve-update-delete-recurring-appointment.md)   
 [Sample: End a Recurring Appointment](sample-end-recurring-appointment-series.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
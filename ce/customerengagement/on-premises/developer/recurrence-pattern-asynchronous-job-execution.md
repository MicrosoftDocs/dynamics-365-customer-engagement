---
title: "Recurrence pattern in asynchronous job execution (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about executing asynchronous system operations one time or on a recurring basis by using a recurrence rule. Use the AsyncOperation.RecurrencePattern attribute to specify the recurrence rule."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: abfb5df5-138b-4c7e-8730-4903aa2be3d3
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Recurrence pattern in asynchronous job execution

You can execute asynchronous system operations one time or on a recurring basis by using a recurrence rule. Use the `AsyncOperation.RecurrencePattern` attribute to specify the recurrence rule. This property is included in the request classes of the<xref:Microsoft.Xrm.Sdk.IOrganizationService> messages that submit asynchronous jobs, such as bulk delete, or bulk detect duplicates. It is also included in the entities that represent asynchronous operations, such as the `AsyncOperation` (system job) entity.  
  
 Use the following format to set the `AsyncOperation.RecurrencePattern` attribute.  
  
|Recurrence pattern|Frequency of job execution|  
|------------------------|--------------------------------|  
|"FREQ=MONTHLY;"|Once a month|  
|"FREQ=WEEKLY;"|Once a week|  
|FREQ=DAILY;"|Once a day|  
|"FREQ=HOURLY;"|Once an hour|  
  
> [!NOTE]
>  A complete format for a recurrence rule is described in the [RFC2445](https://go.microsoft.com/fwlink/p/?LinkId=262221) Internet standard (Internet Calendaring and Scheduling Core Object Specification).  
  
 You can specify how frequently you want to repeat the recurrence rule by using an INTERVAL part of the rule. For example, to execute a job every three days, use the following format: "FREQ=DAILY;INTERVAL=3;". The INTERVAL is an optional part of the recurrence rule. If you do not specify INTERVAL, it is set to 1.  
  
 To run an asynchronous job without recurrence, set this property to a value that is specified in the `AsyncOperation.RecurrencePattern` property programming reference topic for a particular message request class or an entity.  
  
 To specify the start time of the job execution, use the `AsyncOperation.RecurrenceStartTime` property or the <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest.StartDateTime> property in the message request classes or in the records that represent asynchronous operations. If the property is not set, the start time is set to the value that is contained in the `DateTime.Now` property.  
  
### See also  
 <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest.RecurrencePattern>   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDeleteRequest.StartDateTime>   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest.RecurrencePattern>   
 <xref:Microsoft.Crm.Sdk.Messages.BulkDetectDuplicatesRequest.RecurrenceStartTime>   
 [Delete Data in Bulk in Dynamics 365 Customer Engagement (on-premises)](delete-data-bulk.md)   
 [Asynchronous Operation (system job) Entity](asyncoperation-system-job-entity.md)   
 [Asynchronous Service in Dynamics 365 Customer Engagement (on-premises)](asynchronous-service.md)   
 [Supported entities for asynchronous operations](supported-entities-asynchronous-operations.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
---
title: "Default State and Status Reason values in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: a307d287-69c3-49a3-ad3a-935123ffe7c8
caps.latest.revision: 10
ms.author: "rdubois"
manager: "brycho"
---
# Default State and Status Reason values
This topic lists the default **State** and **Status Reason** values for system entities that do not use the default values shown in the following table.  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
|1 : Inactive|2 : Inactive|  
  
<a name="BKMK_Activity"></a>   
## Activity entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Completed|  
|2 : Canceled|3 : Canceled|  
|3 : Scheduled|4 : Scheduled|  
  
<a name="BKMK_Appointment"></a>   
## Appointment entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Free|  
||2 : Tentative|  
|1 : Completed|3 : Completed|  
|2 : Canceled|4 : Canceled|  
|3 : Scheduled|5 : Busy|  
||6 : Out of Office|  
  
<a name="BKMK_Article"></a>   
## Article entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|1 : Draft|1 : Draft|  
|2 : Unapproved|2 : Unapproved|  
|3 : Published|3 : Published|  
  
<a name="BKMK_AuthorizationServer"></a>   
## Authorization Server entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Enabled|  
|1 : Inactive|2 : Disabled|  
  
<a name="BKMK_BulkDeleteOperation"></a>   
## Bulk Delete Operation entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Ready|0 : Waiting For Resources|  
|1 : Suspended|10 : Waiting|  
||11 : Retrying|  
||12 : Paused|  
|2 : Locked|20 : In Progress|  
||21 : Pausing|  
||22 : Canceling|  
|3 : Completed|30 : Succeeded|  
||31 : Failed|  
||32 : Canceled|  
  
<a name="BKMK_Campaign"></a>   
## Campaign entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Proposed|  
||1 : Ready To Launch|  
||2 : Launched|  
||3 : Completed|  
||4 : Canceled|  
||5 : Suspended|  
|1 : Inactive|6 : Inactive|  
  
<a name="BKMK_CampaignActivity"></a>   
## Campaign Activity entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Proposed|  
||0 : In Progress|  
||4 : Pending|  
|5 : System Aborted|  
||6 : Completed|  
|1 : Closed|2 : Closed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_CampaignResponse"></a>   
## Campaign Response entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Closed|2 : Closed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_Case"></a>   
## Case entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : In Progress|  
||2 : On Hold|  
||3 : Waiting for Details|  
||4 : Researching|  
|1 : Resolved|5 : Problem Solved|  
||1000 : Information Provided|  
|2 : Canceled|6 : Canceled|  
||2000 : Merged|  
  
<a name="BKMK_CaseResolution"></a>   
## Case Resolution entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Closed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_ColumnMapping"></a>   
## Column Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
  
<a name="BKMK_Contract"></a>   
## Contract entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Draft|1 : Draft|  
|1 : Invoiced|2 : Invoiced|  
|2 : Active|3 : Active|  
|3 : On Hold|4 : On Hold|  
|4 : Canceled|5 : Canceled|  
|5 : Expired|6 : Expired|  
  
<a name="BKMK_ContractLine"></a>   
## Contract Line entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Existing|1 : New|  
|1 : Renewed|2 : Renewed|  
|2 : Canceled|3 : Canceled|  
|3 : Expired|4 : Expired|  
  
<a name="BKMK_DataImport"></a>   
## Data Import entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Submitted|  
||1 : Parsing|  
||2 : Transforming|  
||3 : Importing|  
||4 : Completed|  
||5 : Failed|  
  
<a name="BKMK_DiscountList"></a>   
## Discount List entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|100001 : Active|  
|1 : Inactive|100002 : Inactive|  
  
<a name="BKMK_DuplicateDetectionRule"></a>   
## Duplicate Detection Rule entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Inactive|0 : Unpublished|  
||1 : Publishing|  
|1 : Active|2 : Published|  
  
<a name="BKMK_Email"></a>   
## Email entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Draft|  
||8 : Failed|  
|1 : Completed|2 : Completed|  
||3 : Sent|  
||4 : Received|  
||6 : Pending Send|  
||7 : Sending|  
|2 : Canceled|5 : Canceled|  
  
<a name="BKMK_Fax"></a>   
## Fax entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Completed|  
||3 : Sent|  
||4 : Received|  
|2 : Canceled|5 : Canceled|  
  
<a name="BKMK_Goal"></a>   
## Goal entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Open|  
|1 : Inactive|1 : Closed|  
||2 : Discarded|  
  
<a name="BKMK_GoalMetric"></a>   
## Goal Metric entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Open|  
|1 : Inactive|1 : Closed|  
  
<a name="BKMK_ImportData"></a>   
## Import Data entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
<a name="BKMK_ImportEntityMapping"></a>   
## Import Entity Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
  
<a name="BKMK_ImportLog"></a>   
## Import Log entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
<a name="BKMK_ImportSourceFile"></a>   
## Import Source File entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Submitted|  
||1 : Parsing|  
||2 : Transforming|  
||3 : Importing|  
||4 : Completed|  
||5 : Failed|  
  
<a name="BKMK_Invoice"></a>   
## Invoice entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : New|  
||2 : Partially Shipped|  
||4 : Billed|  
||5 : Booked (applies to services)|  
||6 : Installed (applies to services)|  
|1 : Closed (deprecated)|3 : Canceled (deprecated)|  
||7 : Paid in Full (deprecated)|  
|2 : Paid|100001 : Complete|  
||100002 : Partial|  
|3 : Canceled|100003 : Canceled|  
  
<a name="BKMK_Lead"></a>   
## Lead entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : New|  
||2 : Contacted|  
|1 : Qualified|3 : Qualified|  
|2 : Disqualified|4 : Lost|  
||5 : Cannot Contact|  
||6 : No Longer Interested|  
||7 : Canceled|  
  
<a name="BKMK_Letter"></a>   
## Letter entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
||2 : Draft|  
|1 : Completed|3 : Received|  
||4 : Sent|  
|2 : Canceled|5 : Canceled|  
  
<a name="BKMK_ListValueMapping"></a>   
## List Value Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
<a name="BKMK_LookupMapping"></a>   
## Lookup Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
<a name="BKMK_MarketingList"></a>   
## Marketing List entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
|1 : Inactive|1 : Inactive|  
  
<a name="BKMK_Opportunity"></a>   
## Opportunity entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : In Progress|  
||2 : On Hold|  
|1 : Won|3 : Won|  
|2 : Lost|4 : Canceled|  
||5 : Out-Sold|  
  
<a name="BKMK_OpportunityClose"></a>   
## Opportunity Close entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Completed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_Order"></a>   
## Order entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : New|  
||2 : Pending|  
|1 : Submitted|3 : In Progress|  
|2 : Canceled|4 : No Money|  
|3 : Fulfilled|100001 : Complete|  
||100002 : Partial|  
|4 : Invoiced|100003 : Invoiced|  
  
<a name="BKMK_OrderClose"></a>   
## Order Close entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Completed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_OwnerMapping"></a>   
## Owner Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
<a name="BKMK_PartnerApplication"></a>   
## Partner Application entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Enabled|  
|1 : Inactive|2 : Disabled|  
  
<a name="BKMK_PhoneCall"></a>   
## Phone Call entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Made|  
||4 : Received|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_PriceList"></a>   
## Price List entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|100001 : Active|  
|1 : Inactive|100002 : Inactive|  
  
<a name="BKMK_Process"></a>   
## Process entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Draft|1 : Draft|  
|1 : Activated|2 : Activated|  
  
<a name="BKMK_ProcessSession"></a>   
## Process Session entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Incomplete|1 : Not Started|  
||2 : In Progress|  
||3 : Paused|  
|1 : Complete|4 : Completed|  
||5 : Canceled|  
||6 : Failed|  
  
<a name="BKMK_Queue"></a>   
## Queue entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
|1 : Inactive|2 : Inactive|  
  
<a name="BKMK_QueueItem"></a>   
## Queue Item entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
|1 : Inactive|2 : Inactive|  
  
<a name="BKMK_QuickCampaign"></a>   
## Quick Campaign entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Pending|  
||2 : In Progress|  
|1 : Closed|3 : Aborted|  
||4 : Completed|  
|2 : Canceled|5 : Canceled|  
  
<a name="BKMK_Quote"></a>   
## Quote entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Draft|1 : In Progress|  
|1 : Active|2 : In Progress|  
||3 : Open|  
|2 : Won|4 : Won|  
|3 : Closed|5 : Lost|  
||6 : Canceled|  
||7 : Revised|  
  
<a name="BKMK_QuoteClose"></a>   
## Quote Close entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Open|  
|1 : Completed|2 : Completed|  
|2 : Canceled|3 : Canceled|  
  
<a name="BKMK_RecurringAppointment"></a>   
## Recurring Appointment entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Free|  
||2 : Tentative|  
|1 : Completed|3 : Completed|  
|2 : Canceled|4 : Canceled|  
|3 : Scheduled|5 : Busy|  
||6 : Out of Office|  
  
<a name="BKMK_RollupQuery"></a>   
## Rollup Query entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Open|  
|1 : Inactive|1 : Closed|  
  
<a name="BKMK_SavedView"></a>   
## Saved View entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|1 : Active|  
||3 : All|  
|1 : Inactive|2 : Inactive|  
  
<a name="BKMK_SdkMessageProcessingStep"></a>   
## Sdk Message Processing Step entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Enabled|1 : Enabled|  
|1 : Disabled|2 : Disabled|  
  
<a name="BKMK_ServiceActivity"></a>   
## Service Activity entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|1 : Requested|  
||2 : Tentative|  
|1 : Closed|8 : Completed|  
|2 : Canceled|9 : Canceled|  
||10 : No Show|  
|3 : Scheduled|3 : Pending|  
||4 : Reserved|  
||6 : In Progress|  
||7 : Arrived|  
  
<a name="BKMK_SystemJob"></a>   
## System Job entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Ready|0 : Waiting For Resources|  
|1 : Suspended|10 : Waiting|  
|2 : Locked|20 : In Progress|  
||21 : Pausing|  
||22 : Canceling|  
|3 : Completed|30 : Succeeded|  
||31 : Failed|  
||32 : Canceled|  
  
<a name="BKMK_Task"></a>   
## Task entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Open|2 : Not Started|  
||3 : In Progress|  
||4 : Waiting on someone else|  
||7 : Deferred|  
|1 : Completed|5 : Completed|  
|2 : Canceled|6 : Canceled|  
  
<a name="BKMK_TransformationMapping"></a>   
## Transformation Mapping entity  
  
|State|Status Reason|  
|-----------|-------------------|  
|0 : Active|0 : Active|  
  
## See Also  
 [Create and edit fields](Create%20and%20edit%20fields.md)

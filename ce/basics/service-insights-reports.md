---
title: "Service insights reports (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 541595fb-8b5c-4f76-bdd1-80dd2ca3d8d2
caps.latest.revision: 16
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# Reports for customer service insights

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] includes many system reports that you can use to gain insights into how your business is doing. You can use these reports as is or customize them for your needs. For more information about customized reports, see [Customize and organize reports](../customize/customize-organize-reports.md). The following will provide insights into your customer service efforts: 

|Description|More information|  
|-----------------|----------------------|  
|Types of opened and resolved cases|[Case Summary Table report](../basics/service-insights-reports.md#BKMK_CaseSummary)|  
|Cases with no recent activity|[Neglected Cases report](../basics/service-insights-reports.md#BKMK_NeglectedCases)|  
|Amount and length of service activities|[Service Activity Volume report](../basics/service-insights-reports.md#BKMK_ServiceActivity)|  
|Activity patterns|[Activities report](#BKMK_Activities)|  
|Most searched knowledge base articles|[Top knowledge base articles report](../basics/service-insights-reports.md#BKMK_TopKB)|  


<a name="BKMK_CaseSummary"></a>  
## Case Summary Table report
Lower support calls and improve your product or service.   
This report tracks service cases and tells you why customers are contacting support.  
  
 For example, if your company sells cell phones and you find out that majority of   
the support calls are due to a faulty phone battery, you can take this information  
 to the team that makes the phone battery so they can fix the issue.   
This will improve your product and drive support calls down.  
  
 The report provides a list of cases that you can group by  
 owner, customer, status reason, product, priority, subject, origin, case type, satisfaction, service level, or severity.  
  
 ![Case Summary Table reportin Dynamics 365 for Customer Engagement apps](../basics/media/case-summary-table-report.png "Case Summary Table reportin Dynamics 365 for Customer Engagement apps")  

<a name="BKMK_NeglectedCases"></a>
# Neglected Cases report
Improve your service team’s KPIs and get your cases closed. Quickly identify and take action on cases that haven’t been updated recently. The report also shows the name of the service agent assigned to the case - use this information to follow-up with your team and to start resolving these cases.  
  
 When you run the report, choose the number of days that cases haven’t been updated. The report shows a list of open cases that have no changes to activities, including scheduled activities and notes.  
  
 ![Neglected Cases report in Dynamics 365 for Customer Engagement apps](../basics/media/negected-cases-report.png "Neglected Cases report in Dynamics 365 for Customer Engagement apps")  

<a name="BKMK_ServiceActivity"></a>
# Service Activity Volume report
Use this report to review the patterns in service activity volume.  
  
 The report displays either the duration of or number of service activities grouped by services, resources, time periods, and additional criteria.  
  
<a name="BKMK_TopKB"></a>
# Top knowledge base articles report
The information in the report helps you identify which issues your customers are asking about so that you can address those problems and improve your product or service. When a service agent receives a support call or email, the agent searches the knowledge base to see if there is a KB article that can answer the customer’s question. This report tells you which of those KB articles are being used the most.  
  
 You can change the **Group by** filter to see knowledge base articles grouped by subject of the article or case, or by the product associated with the case.  
  
 ![Report of  top knowledge base articles in Dynamics 365 for Customer Engagement apps](../basics/media/top-kb-articles.png "Report of  top knowledge base articles in Dynamics 365 for Customer Engagement apps")  
  
<a name="BKMK_Activities"></a>  
# Activities report
To provide better service to your customers, get a quick view of all the activities associated with support cases such as phone calls, tasks, emails, appointments, and case resolution.  Use the information in this report to look at the details of each activity and identify patterns to make improvements in how you communicate with your customers.  
  
 When you run the report, choose **Show All** to get a detail view of all the activity. Activities can be grouped by owner or activity type, or by the record the activity is associated to.  
  
 ![Exmple of an Activities Report in Dynamics 365 for Customer Engagement apps](../basics/media/activities-report.png "Exmple of an Activities Report in Dynamics 365 for Customer Engagement apps")  
 
### See also  
 [Run a report](../basics/run-report.md)   
 [Troubleshoot problems with data not displaying in a report](../basics/troubleshoot-reports.md)   
 [Customize and organize reports](../customize/customize-organize-reports.md)

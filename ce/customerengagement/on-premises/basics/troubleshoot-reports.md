---
title: "Troubleshoot problems with data not displaying in a report (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 05/05/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 886fee0f-d97b-4baf-9019-63ee11cdf329
caps.latest.revision: 27
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser

---
# Troubleshoot problems with data not displaying in a report

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Troubleshoot problems with data not displaying in a report](/powerapps/user/troubleshoot-reports)

There are several possible reasons why data that you expect to be in a report does not appear:  
  
- **Insufficient security permissions**. If you don't have permission in Dynamics 365 Customer Engagement (on-premises) to view a record, it will not appear in the report.  
  
- **Data is not entered.** The person entering data may have left fields empty.  
  
- **Data does not match the criteria for the report.** Many reports include a default filter that displays only active records, or you may have selected criteria that don't have any matching record. Try changing the report filter. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Edit the default filter of a report](../basics/edit-default-filter-report.md)  
  
- **You may be viewing a cached copy of the report.** By default, data in Dynamics 365 Customer Engagement (on-premises) reports is pulled from the database each time you run a report. However, your system administrator may have changed a report to run from the cache. If data you entered recently is not included in the report, you may have an older version of the report from the cache. To refresh the report, on the Report toolbar, click or tap the **Refresh** button ![Refresh button](../basics/media/htm-lviewer-grid-refresh.gif "Refresh button").  
  
- **You may not have permission to read records in a sub-report.** If you do not have permission to read record types that are included in a sub-report, you will get an error message saying that the sub-report could not be displayed.  
  
- **Your Microsoft Internet Explorer privacy settings may block required cookies.** For chart reports, if instead of seeing the chart, you see a red letter X, your privacy settings may be blocking a cookie that is required for the chart control. To fix this problem, in your browser, enable cookies for the server that is running Reporting Services.  
  





[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
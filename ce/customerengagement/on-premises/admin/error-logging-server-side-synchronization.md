---
title: "Error logging for server-side synchronization  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 02206239-11d5-44fa-b634-05ce5fda352f
caps.latest.revision: 21
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Error logging for server-side synchronization 

In this topic, you will learn about the error logging tasks performed by server-side synchronization. server-side synchronization generates alerts if an error occurs while processing email. An error is classified based on the nature of the error and on the object the error was encountered for.  

 The following table shows classification of errors based on the nature of the errors.  


|                                                                                                                                                                                                                                                                      Transient Errors                                                                                                                                                                                                                                                                       |                                                                                                                                                                                                                                                                                 Permanent Errors                                                                                                                                                                                                                                                                                  |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| -   Errors are temporary in nature and may get fixed automatically after certain attempts. If the error persists after reaching the configured retry count, a new error (without changing the error code) is logged as a permanent error.<br />-   These errors do not require a direct corrective action by a Dynamics 365 Customer Engagement (on-premises) user, but an administrator should look for any reliability or throttling issues.<br />-   All errors appear in the Warning section of the administrator’s and user’s alert wall. | -   These are permanent in nature and mostly occur when the transient errors remain unresolved even after certain attempts. Permanent errors can also be triggered directly without any transient errors (for example: password expired).<br />-   Email processing for the affected mailboxes is stopped as a result of these errors. These require a corrective action by the mailbox owner or a Customer Engagement (on-premises) administrator.<br />-   All permanent errors appear in Error section of the administrator’s and user’s alert wall. |

 The errors are also classified based on the object on which the error is encountered:  

- **Email-level errors.** Errors that are specific to an email and prevent processing of an individual email without impacting processing of other emails. Error alerts are displayed in the Alerts section of the email form.  

- **Mailbox-level errors.** Errors that are specific to a mailbox and prevent processing of all emails in a mailbox and require corrective action from the respective mailbox owner. Error alerts are displayed in the alerts section of the email form, mailbox owner’s alert wall, and on the Mailbox form.  

- **Profile-level errors.** Errors which prevent processing of all emails in one or more mailboxes and require corrective action from the associated email server profile owner. Error alerts are displayed on the alerts section of the email server profile form, alerts wall of the owner of the email server profile, and on the alert walls of the impacted mailbox owners - but no action is required from them.  

To know how to view the alerts and the actions you can take on these alerts, see [Monitor email processing errors](../admin/monitor-email-processing-errors.md).  

### See also  
 [Troubleshooting and monitoring server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md)   
 [Supported scenarios for server-side synchronization](../admin/supported-email-service-configurations-server-side-synchronization.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
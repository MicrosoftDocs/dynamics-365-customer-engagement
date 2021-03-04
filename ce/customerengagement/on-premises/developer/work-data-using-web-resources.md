---
title: "Work with Dynamics 365 Customer Engagement (on-premises) data using web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This doc explains how you can use JavaScript web resources to access Dynamics 365 Customer Engagement (on-premises) data from within the application."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: f1a0de36-a963-43c9-a878-c85c793cd089
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Work with Customer Engagement (on-premises) data using web resources

You can use [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources to access [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] data from within the application. There are three web services you can use in the application to access data by using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]. The Organization data service is deprecated with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. It is recommended to use Web API instead of Organization service when creating applications that connect to the [!INCLUDE[cc_dyn365_ce_web_services](../includes/cc-dyn365-ce-web-services.md)] and invoke methods to perform common business data operations like create, delete, update, and find.    


|                                                         Web Service                                                          |                                                                                                                                                                                                                                                                                                          Description                                                                                                                                                                                                                                                                                                           |
|------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                         **Web API**                                                          |                                   The Web API was introduced with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. It provides a RESTful web service with full compatibility with the organization service. It uses JSON in the body of the HTTP requests and responses, which makes it very suitable for use with [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get started with the Web API (client-side JavaScript)](webapi/get-started-web-api-client-side-javascript.md)                                    |
|      **Organization Data Service**<br /><br /> Also known as the “OData endpoint” or “REST endpoint for web resources.”      | The organization data service is deprecated with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Use the Web API to access [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data for solutions that don’t need to work with earlier versions. The organization data service remains available and you can use it so that code written for earlier versions will continue to work. For more information, see the [!INCLUDE[pn_crm_2015](../includes/pn-crm-2015.md)] SDK topic: [Use the OData endpoint with web resources](https://msdn.microsoft.com/library/gg334279\(v=crm.7\).aspx). |
| **Organization service**<br /><br /> Also known as the “Modern app SOAP endpoint” and the “SOAP endpoint for web resources.” |                                                           The organization service can be used but it is much more complex than the Web API with [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] because the HTTP requests and responses are sent using XML, which must conform to specific schema and namespaces. For more information, see the [!INCLUDE[pn_crm_2015](../includes/pn-crm-2015.md)] SDK topic: [Use the Modern app SOAP endpoint for modern applications with web resources](https://msdn.microsoft.com/library/gg490657\(v=crm.7\).aspx).                                                            |

 Each of these web services can use the authentication provided by the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application within web resources without the need to include any code to implement authentication. For information about how to use these endpoints with authentication from outside the web application, see [Authenticate users in Dynamics 365 Customer Engagement (on-premises)](authenticate-users.md).  

## In This Section  

## Related Sections  
 [Get started with the Web API (client-side JavaScript)](webapi/get-started-web-api-client-side-javascript.md)  

 [Extend Dynamics 365 Customer Engagement on the client](extend-client.md)  

 [Use JavaScript with Dynamics 365 Customer Engagement (on-premises)](use-javascript.md)  

 [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)  

 [Open Forms, Views, Dialogs and Reports with a URL](open-forms-views-dialogs-reports-url.md)  

 [Open forms, views, and dashboards in Dynamics 365 Customer Engagement mobile client with a URL](open-forms-views-dashboards-mobile-client-url.md)  

 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)  

 [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)  

 [Client API Reference](clientapi/reference.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
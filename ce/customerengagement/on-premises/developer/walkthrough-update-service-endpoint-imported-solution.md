---
title: "Walkthrough: Update a service endpoint imported from a solution (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The walkthrough demonstrates updating a service endpoint imported from a solution."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8c860992-d3c6-4bfa-86c4-98018af6f22c
caps.latest.revision: 8
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer

---
# Walkthrough: Update a service endpoint imported from a solution

An extra step is required after importing into an organization a solution containing one or more service endpoints configured for SAS authorization. When the solution containing the service endpoints is exported, the exported solution does not contain the SAS Key for each service endpoint. After importing the solution into an organization, you must perform an additional step to provide the SAS Key for each service endpoint.  
  
 Follow these steps to set the SAS Key for each service endpoint after solution import.  
  
### Update the SAS Key  
  
1. Run the Plug-in Registration Tool, which can be found in the Tools folder of the [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)] (or later) SDK download. Previous releases of the tool do not support SAS authorization.  
  
2. Using the tool, sign in to the organization that contains the imported solution.  
  
3. Select the target service endpoint in the tab view of the organization.  
  
4. Select **Update**. You should see the following form with the fields already filled in.  
  
   ![Update service endpoint SAS key value](media/sas-key.PNG "Update service endpoint SAS key value")  
  
5. The **SAS Key** field is displayed with a value of "*******".  Replace that value with the correct SAS key value. You can obtain the SAS Key for your [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] messaging entity (queue, topic, etc.) from the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][classic portal](https://manage.windowsazure.com).  
  
6. Select **Save**.  
  
### See also  
 [Azure extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md)   
 [Service Bus authentication and authorization](https://azure.microsoft.com/documentation/articles/service-bus-authentication-and-authorization/)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
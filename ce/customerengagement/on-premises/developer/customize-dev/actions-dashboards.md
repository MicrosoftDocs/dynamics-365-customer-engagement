---
title: "Actions on dashboards (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about performing actions such as create, retrieve, update, or delete, on organization-owned and user-owned dashboards. "
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 586a10d6-4448-474e-9428-d13520f52213
caps.latest.revision: 27
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Actions on dashboards

You can perform actions such as create, retrieve, update, or delete, on organization-owned and user-owned dashboards.  
  
## Actions on an Organization-Owned Dashboard  
 To perform the following actions on an organization-owned dashboard (`SystemForm`), you must have the System Administrator or the System Customizer role assigned to your account in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]:  
  
- Create, retrieve, update, and delete. You can create or update an organization-owned dashboard by using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)] or by customizing the entity form. For detailed information about creating a dashboard, see [Create a Dashboard](create-dashboard.md).  
  
- Set an organization-owned dashboard as the default dashboard for an organization by setting the `SystemForm.IsDefault` attribute value to `true` while creating or updating the dashboard.  
  
  > [!IMPORTANT]
  >  Using the methods available in the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)], it is possible to set two dashboards as the default. Make sure that no other dashboard is the default dashboard for the organization before updating this setting programmatically.  
  
  After you update an organization-owned dashboard, you must publish the metadata changes to make it visible across the organization. You can use the <xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest> message or <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest> message to publish the changes made for an organization-owned dashboard. For a sample code that demonstrates this, see [Sample: Create, Retrieve, Update and Delete (CRUD) a Dashboard](sample-create-retrieve-update-delete-dashboard.md).  
  
  For a list of supported messages on the organization-owned dashboard entity, see [SystemForm Entity](../entities/systemform.md).  
  
## Actions on a User-Owned Dashboard  
 You can perform the following actions on a user-owned dashboard (`UserForm`):  
  
- Create, retrieve, update, and delete. For detailed information about creating a user-owned dashboard, see [Create a Dashboard](create-dashboard.md).  
  
- Change the ownership of a user-owned dashboard by assigning it to another user or team using the <xref:Microsoft.Crm.Sdk.Messages.AssignRequest> message.  
  
- Retrieve the access that the specified security principal (user or team) has to a user-owned dashboard using the <xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest> message. You can also retrieve all the security principals (users or teams) that have access to a user-owned dashboard, along with their access rights to the user dashboard using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest> message.  
  
- Collaborate with other users and teams on specific areas by sharing a user-owned dashboard with them using the <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>, <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>, and <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest> messages.  
  
  For a list of supported messages on the user-owned dashboard entity, see [UserForm Entity](../entities/userform.md).  
  
### See also  
 [Dashboards for Microsoft Dynamics 365 Customer Engagement](analyze-data-with-dashboards.md)   
 [Using FormXML for Dashboards](understand-dashboards-dashboard-components-formxml.md)   
 [Create a Dashboard](create-dashboard.md)   
 [Sample Dashboards](sample-dashboards.md)   
 [Dashboard Entities](dashboard-entities.md)   
 [Sample: Create, Retrieve, Update and Delete (CRUD) a Dashboard](sample-create-retrieve-update-delete-dashboard.md)   
 [Sample: Assign a User-Owned Dashboard to Another User](sample-assign-user-owned-dashboard-another-user.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
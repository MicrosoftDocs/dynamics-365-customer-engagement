---
title: "Register and Deploy Plug-Ins (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about register plug-ins and custom workflow activities with Dynamics 365 Customer Engagement (on-premises) using the Plug-in Registration Tool."
ms.custom: on-premise
ms.date: 1/24/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
f1_keywords: 
  - plugins
  - plugin
ms.assetid: c3ee3447-ec0d-494e-8b35-4ec58ce93eea
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Register a plug-in to be deployed on-premise

Plug-ins and custom workflow activities are custom code that you develop to extend the existing functionality of Dynamics 365 Customer Engagement (on-premises). Before a plug-in or custom workflow activity can be used, it must be registered with the server. A plug-in and custom workflow activity registration tool is available for download.

General information about plug-in and custom workflow assembly registration can be found in the Dataverse topics [Register a plug-in](/powerapps/developer/common-data-service/register-plug-in) and [Register your assembly](/powerapps/developer/common-data-service/workflow/workflow-extensions#register-your-assembly). The information that follows below is specific to on-premises plug-in development.

 While this topic focuses primarily on plug-ins, most of the information is also applicable to custom workflow activities. One difference between the two is that for custom workflow activity assemblies, you register just the assembly. For plug-ins, you register the plug-in assembly and one or more steps per plug-in. For more information about custom workflow activities, see [Custom Workflow Activities (Workflow Assemblies)](custom-workflow-activities-workflow-assemblies.md).

> [!IMPORTANT]
> Do not register any plug-in or custom workflow activity unless it is obtained from a reliable and trusted source.

<a name="bkmk_pluginstor"></a>

## Plug-in Storage

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
For an on-premises deployment, plug-ins that are not registered in the sandbox can be stored in the Dynamics 365 Server's database or the *on-disk* file system. We strongly recommend that you store your production-ready plug-ins in the Dynamics 365 Customer Engagement (on-premises) database, instead of on-disk. Plug-ins stored in the database are automatically distributed across multiple Dynamics 365 Servers in a data center cluster. On-disk storage of plug-ins is useful for debugging plug-ins using [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)]. However, you can debug a plug-in that is stored in the database. For more information, see [Debug a Plug-in](debug-plugin.md).  

Plug-ins registered in the sandbox must be stored in the database regardless of the Dynamics 365 Customer Engagement (on-premises) deployment (on-premises, IFD, or Online).

<a name="bkmk_deployment"></a>

## Deployment

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
For on-premises or Internet-facing (IFD) Dynamics 365 Customer Engagement (on-premises) installations, when you deploy plug-ins from another computer to the Dynamics 365 Server disk (on-disk deployment), the plug-in assembly must be manually copied to the server before registration. The assembly must be deployed to the `<installdir>`\Program Files\Microsoft CRM\server\bin\assembly folder on each server where the plug-in is to execute.  

Plug-in registration should be done after the assembly has been copied to the …\bin\assembly folder on the server to prevent the situation where a system user causes an event in Dynamics 365 Customer Engagement (on-premises) to be raised but the registered plug-in assembly does not yet exist on the server. For server database deployment, the plug-in assembly is automatically copied during plug-in registration so that the earlier situation is not an issue.  

Depending on your plug-in’s design, your plug-ins may require other referenced assemblies to run. Regardless of whether you deploy your plug-in to the database or disk, if your plug-in requires other assemblies to run, you must put copies of these assemblies in the global assembly cache on each server where the plug-in is to execute. 

**To move a plug-in from a development environment to a staging or production server**

1. On the development computer, build the plug-in code. Do not include debug information. Optimize the plug-in for performance.
2. Register the plug-in in the Dynamics 365 Server database.
3. Using the Dynamics 365 Customer Engagement (on-premises) web application, create a solution or use an existing one, and add the plug-in to that solution.
4. After you have added any other desired components to the solution, export the solution.
5. Import the solution on to the staging or production server.

<a name="bkmk_securityrestrictions"></a>

## Security Restrictions

 There is a security restriction that enables only privileged users to register plug-ins. For plug-ins that are not registered in the sandbox (isolation), the system user account under which the plug-in is being registered must exist in the **Deployment Administrators** group of Deployment Manager. Only the System Administrator user account or any user account included in the **Deployment Administrators** group can run Deployment Manager.  

> [!IMPORTANT]
> For non-isolated plug-ins, failure to include the registering user account in the **Deployment Administrators** group results in an exception being thrown during plug-in registration. The exception description states "Not have enough privilege to complete Create operation for an SDK entity."  

 For plug-ins registered in the sandbox (isolation mode), the system user account under which the plug-in is being registered must have the System Administrator role. Membership in the **Deployment Administrators** group is not required.  
  
### See also

 [Plug-in Development](plugin-development.md)<br />
 [Debug a Plug-in](debug-plugin.md)<br />
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solutions](package-distribute-extensions-use-solutions.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
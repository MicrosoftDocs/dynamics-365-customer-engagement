---
title: "Best practices (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This topic describes best practices for developing with Dynamics 365 Customer Engagement (on-premises)."
ms.custom: 
ms.date: 07/24/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 42dcebf5-a624-45b9-b719-20e5882d5ca2
caps.latest.revision: 89
author: JimDaly
ms.author: jdaly
manager: annbe
search.audienceType: 
  - developer

---
# Best practices for developing with Dynamics 365 Customer Engagement

This topic describes best practices for customizing [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)].  

> [!IMPORTANT]
>  Review [Supported extensions for Dynamics 365 Customer Engagement (on-premises)](supported-extensions.md) to learn about supported and unsupported techniques for customization.  

<a name="Performance"></a>   

## Performance best practices  

 The following best practices can help you write code that performs better.  

### Use multiple threads  

 Add threading support to your application to break up the work across multiple CPUs. This suggestion assumes that you are running your code on a multiprocessor system. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [NET Framework Advanced Development Guide article on Managed Threading](https://msdn.microsoft.com/library/3e8s7xdd.aspx).  

### Allow the system to create GUIDs 

 Allow the system to automatically assign the **GUID** (Id) for you instead of manually creating it yourself. This suggestion allows 
Dynamics 365 Customer Engagement (on-premises) to take advantage of sequential GUIDs, which provide better SQL performance. 
The following sample code shows how to call the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method to obtain a system-assigned `GUID`.  

```csharp
// Instantiate an account object.
Account account = new Account { Name = "Fourth Coffee" };  
// Create an account record named Fourth Coffee and retrieve the GUID.
accountId = serviceProxy.Create(account);  
```
### Use early-bound types

Use the <xref:Microsoft.Xrm.Sdk.Entity> class when your code must work on entities and attributes that aren’t known at the time the code is written. 
In addition, if your custom code works with thousands of entity records, use of the <xref:Microsoft.Xrm.Sdk.Entity> class results in slightly better 
performance than the early-bound entity types. However, this flexibility has a disadvantage because you cannot verify entity and attribute names at compile time. If your entities are already 
defined at code time and slight performance degradation is acceptable, you should use the early-bound types that you can generate by using the 
[!INCLUDE[sdk_CodeGenUtility](../includes/sdk-codegenutility.md)] tool. 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Early Bound Entity Classes in Code](org-service/use-early-bound-entity-classes-code.md)  

### Disable plug-ins

 If possible, disable registered plug-ins before you run your application.

### Write plug-ins that execute faster

Always write a plug-in that takes the least time to perform its intended task. For example, the 
<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method is frequently processed in Dynamics 365 Customer Engagement (on-premises). 
If you register a plug-in on that message, your plug-in can have a significant performance impact on the system because it executes every time that the `Execute` method is processed, which frequently occurs.  

If you intend to register your plug-ins for synchronous execution, we recommend that you design them to complete their operation in less than 2 seconds. 
It’s best to minimize processing time in plug-ins to maintain interactivity of the client applications that are connected to the same organization service that executes the plug-in.  

<a name="limitdata"></a>

### Limit the data you retrieve

When you use the methods that retrieve data from the server, retrieve the minimum amount of data that your application needs. 
You do this by specifying the column set, which is the set of entity attributes to retrieve.  

For example, it is rarely a good idea to retrieve all the metadata with the `RetrieveAllEntities` message using the 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> class, specifying the 
<xref:Microsoft.Xrm.Sdk.Metadata.EntityFilters.All>` entity filter for the 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest.EntityFilters> property. 
Instead, you might achieve better performance if you restrict the entity filter, or use one of the following message request classes: 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest>, 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveOptionSetRequest>, 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest>, 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRelationshipRequest> or 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMetadataChangesRequest>. 
The RetrieveMetadataChanges message allows for constructing a query to return just the metadata you need or the metadata that has changed. 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Retrieve and Detect Changes to Metadata](retrieve-detect-changes-metadata.md).  

### Limit the number of entities that are enabled for offline use

Carefully consider if an entity must be available for people while working offline.  Each entity that you enable for offline capability directly affects the time required for people to synchronize data when they come back online. This is especially true for people with less powerful computers.

### Limit operations that cascade to related entities

When you use the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method or 
<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message, do not set the `OwnerId` attribute on a record unless the owner has actually changed. 
When you set this attribute, the changes often cascade to related entities, which increases the time that is required for the update operation. 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Cascading behavior](entity-relationship-behavior.md#BKMK_CascadingBehavior)  

### Adjust proxy settings on the client (on-premises only)

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 

A proxy server sits between a client application, such as a web browser, and the actual target server. When a computer is in a LAN, it can use a proxy server to connect to the Internet. 
In this case, the proxy server is combined with, or is a part of, the gateway server and firewall server. The proxy can cache web requests and serve multiple client requests by using its cached data. 
If the requested data is not present in the cache of the proxy server, it forwards the request to the actual server by using its own IP address. 
Here, the proxy server acts on behalf of the client computer.  

Although a proxy server can act as a cache server and can help load a webpage faster, it can sometimes decrease performance if it is used incorrectly.

Frequently, people avoid manual proxy configuration and use automatic proxy configuration. 
This shortcut helps in load balancing the proxy servers, but depending on the complexity of the configuration script, a significant delay can be experienced when you use automatic proxy configuration.  

When the Dynamics 365 Server is installed, you can bypass the proxy server to achieve better throughput. 

The server offers a local web address that requires no proxy to be reached. You can select **Bypass proxy server for local addresses** and provide the fully qualified domain name of the 
Dynamics 365 Server in the exceptions list. This gives better throughput when records are created by using the SDK assemblies.  

<a name="caching"></a>

### Improve service channel allocation performance

You can establish a connection to the Dynamics 365 Customer Engagement (on-premises) web services and authenticate users by using the 
<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> and 
<xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy> service proxy classes. 
However, improper use of these service proxy classes can sometimes reduce application performance. Therefore, if you understand when and how to use the different client 
classes that are available in the SDK, you can often obtain better application performance.  

When you establish a [!INCLUDE[pn_WCF_long](../includes/pn-wcf-long.md)] service channel by using a service endpoint, for example, by using the organization web service, your application must perform two time consuming operations: metadata download from the endpoint and user authentication. 
You can improve performance if your application performs these operations a minimum number of times for each application session. 

The <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> constructor shown here performs both these operations any time a service proxy object is created.  

```csharp
OrganizationServiceProxy (Uri uri, Uri homeRealmUri, ClientCredentials clientCredentials, 
    ClientCredentials deviceCredentials)  
```

You typically obtain better performance if your application uses this constructor to create an instance of the service proxy by using this constructor one time during the application 
session and cache the returned reference for use in different code paths within your application. 
Notice that the returned service reference is not thread safe so multi-threaded applications will need to allocate one instance per thread. 
Applications must also call `Dispose` on the service proxy object before they terminate in order to free service channel allocated resources.  

The service proxy class performs the metadata download and user authentication by using the following class methods.

```csharp
IServiceManagement<IOrganizationService> orgServiceManagement = 
    ServiceConfigurationFactory.CreateManagement<IOrganizationService>(
    new Uri(organizationUrl));

AuthenticationCredentials authCredentials = orgServiceManagement.Authenticate(credentials);
```
The <xref:Microsoft.Xrm.Sdk.Client.ServiceConfigurationFactory>.<xref:Microsoft.Xrm.Sdk.Client.ServiceConfigurationFactory.CreateManagement*> method performs the metadata download while the 
<xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1.Authenticate(Microsoft.Xrm.Sdk.Client.AuthenticationCredentials)> method authenticates the user. 
The returned objects from these methods are thread safe and can be statically cached by your application. 
You can then use these objects to construct a service proxy object that uses one of the other available constructors.  

```csharp  
OrganizationServiceProxy (orgServiceManagement, authCredentials.ClientCredentials)
OrganizationServiceProxy (orgServiceManagement, authCredentials.SecurityTokenResponse)  
```

By caching the service management and authenticated credential objects, your application can more efficiently construct the service proxy objects more than one time per application session. 
If you enable early-bound types on <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> through one of the 
<xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.EnableProxyTypes> methods, you must do the same on all service proxies that are created 
from the cached <xref:Microsoft.Xrm.Sdk.Client.IServiceManagement`1> object. 
If your application uses the metadata, we recommend that it caches the metadata that it retrieves and periodically calls the 
<xref:Microsoft.Xrm.Sdk.Messages.RetrieveTimestampRequest> message to determine whether it must refresh the cache.  

In addition, monitor your [!INCLUDE[pn_WCF_short](../includes/pn-wcf-short.md)] security token (<xref:Microsoft.Xrm.Sdk.Client.SecurityTokenResponse.Token>) 
and refresh it before it expires so that you do not lose the token and have to start over with authentication. 
To check the token, create a custom class that inherits from the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> or 
<xref:Microsoft.Xrm.Sdk.Client.DiscoveryServiceProxy> class and that implements the business logic to check the token. 
Or wrap the proxy classes in a new class. Another technique is to explicitly check the token before each call to the web service. Example code that demonstrates these techniques can be found in the `ManagedTokenDiscoveryServiceProxy`, `ManagedTokenOrganizationServiceProxy`, and `AutoRefreshSecurityToken` classes in the [Helper Code: ServerConnection Class](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/SampleHelpers.cs) topic.  

<a name="CustomizationBestPractices"></a>

## Customization best practices
 The following best practices can help you customize and extend Dynamics 365 Customer Engagement (on-premises).  

### Best practices for Dynamics 365 Customer Engagement (on-premises)

The [Microsoft Dynamics 365 Customer Engagement (on-premises) patterns & principles for solution builders](https://go.microsoft.com/fwlink/p/?LinkID=533946) white paper download provides guidance specifically about building solutions using [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  

### Using custom entities and attributes

Always use the entity name to refer to entities in code and queries. Do not use the object type code (also referred to as entity type) code because the integer value varies for custom entities in different organizations.

 Save space on your server by using these techniques:

- Create custom attributes for existing entities instead of creating a new entity.
- Rename existing entities to make the entities more meaningful.

### When should you customize an entity?

Customize a system entity, such as the opportunity entity, instead of replacing it with a new custom entity so that you can use the any built-in features in an existing entity.

### When to use plug-ins vs. workflow?

As a developer who is interested in extending or customizing Dynamics 365 Customer Engagement (on-premises), you can choose from several methods to perform your tasks. 
In addition to adding client-side JavaScript code to a form or adding custom ASP.NET pages, you can write a plug-in or create a custom workflow by using the web interface that calls a 
custom workflow activity. How do you decide when to use a plug-in and when to use a workflow? The technology that you use depends on the task that you have to perform and who will author the customization.  

For example, you must use a synchronous plug-in real-time workflow if you want to execute custom code immediately before or after the core platform operation executes and before the result of the operation is returned from the platform. You cannot use an asynchronous workflow or asynchronous plug-in in this situation because they are queued to execute after the core operation finishes 
executing. Therefore, you cannot predict when they will run. If you want to add custom functionality to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], workflows, custom workflow activities, and plug-ins are supported, but custom XAML workflows are not.

Evaluate these technologies and select the one that best suits your business objectives after you consider the deployment, performance, and maintenance concerns of your plug-in or workflow solution.  

The following table summarizes the characteristics of plug-ins and workflows.  


|Criteria|Plug-in|Workflow|
|--|--|--|
|Execution before or after the core platform operation (Create, Update, Delete, and so on)|Executes immediately before or after the core operation (synchronous).<br /><br /> Can also be queued to execute after the core operation (asynchronous).|Asynchronous workflows are queued to execute after the core operation.<br /><br /> Real-time workflows have similar characteristics to plug-ins.|
|Performance impact on the server| Synchronous plug-ins can increase the platform response time because they are part of the main platform processing.<br /><br /> Asynchronous plug-ins have less impact on server response time because the code is run in a different process. |Asynchronous workflows have less impact on server response time because the code is run in a different process.<br /><br /> Real-time workflows have similar performance characteristics to sandboxed plug-ins.  |
| Security restrictions|To register a plug-in with the platform requires a System Administrator or System Customizer security role and membership in the Deployment Administrator group.|Users can interactively create workflows in the web application.<br /><br /> However, to register a custom workflow activity, the deploying user must have the same security roles as those required for registering plug-ins.|
|Dynamics 365 Customer Engagement (on-premises) version (SKU) support | Supported in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] when registered in the sandbox. May be supported in partner-hosted installations at the discretion of the partner.|Workflows are supported by all [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] deployment. Custom workflow activities are  supported in the sandbox of [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], and in or outside the sandbox for on-premises/IFD deployments. |
|Length of processing time |A plug-in registered for synchronous or asynchronous execution is restricted to complete its execution in a two-minute time limit. |  Works well for either short or long processes. However, each activity in a workflow cannot take longer than two minutes to complete.  |
| Works when the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] client is offline |Both online and offline are supported. |Workflows do not execute when offline. |
|Process and data persistence|  Plug-ins execute until they are completed. Plug-ins must be written to be stateless where no in-memory data is persisted.| Asynchronous workflows can be paused, postponed, canceled, and resumed through SDK calls or by the user through the web application. The state of the workflow is automatically saved before it is paused or postponed.<br /><br /> Real-time workflows cannot have any wait states. They must execute to completion just like plug-ins. |
|Impersonation | Plug-ins can perform data operations on behalf of another system user.  | Asynchronous workflows cannot use impersonation, while real-time workflows can. Real-time workflows can execute either as the owner of the workflow or as the calling user.|
| Authoring|  Software engineers or programmers can author plug-ins.  |Anyone, including an end user, business analyst, or administrator can author workflows if they have the proper permissions.|

There is no significant performance impact on the server between an asynchronous plug-in and a workflow.

### What type of workflow is better?

From a performance perspective, is it better to create a single long workflow or is it better to have multiple child workflows and call them in one parent workflow? 
The child workflow approach achieves lower throughput, but it is more manageable if you frequently change your workflow definition. 
Compilation overhead is not a major concern because the workflow is compiled only during publishing. However, Dynamics 365 Customer Engagement (on-premises) incurs overhead when it starts each workflow instance. The overhead occurs when all entities that are used in the workflow are retrieved and the child workflow is started in a two-step 
process that includes a 'Workflow Expansion Task' and the actual workflow instance. Therefore, for maximum throughput, use a single long workflow.  

### How should you mark your custom workflow activity as completed?

The return value from the `Execute` method is used by the workflow runtime to mark the activity as “completed.” 
You should use `return base.Execute(executionContext)` unless the activity bypasses base class functionality. Avoid returning `ActivityExecutionStatus.Closed`. 
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [ActivityExecutionStatus Enumeration](https://msdn.microsoft.com/library/system.workflow.componentmodel.activityexecutionstatus.aspx)  

<a name="how-to-report-exceptions-custom-workflow-activities"></a> 
### How should you report exceptions in custom workflow activities?

You should throw an <xref:Microsoft.Xrm.Sdk.InvalidPluginExecutionException> in your code. This error will be shown in the workflow instance form.

### Can you define custom entities that are specific to business units?

Custom entities have privileges for each security role but not for each business unit. To define custom entities that are visible only to specified business units, 
you must create different security roles for each business unit and grant privileges to the custom entity in the appropriate role.

<a name="Security"></a>

## Security best practices

Follow these guidelines to help protect your business data.

### General
Best practices for securing your implementation of Dynamics 365 Customer Engagement (on-premises) include the following:

- Establish an approved security data plan for your organization's Dynamics 365 Customer Engagement (on-premises) implementation.  
- Assign the least privileges required when you set up your application pool.  
- Require that all users use strong passwords for their accounts.

<!-- This is an on-prem topic, not yet migrated. Put in a different link for a placeholder
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security Considerations for Dynamics 365 Customer Engagement](https://technet.microsoft.com/library/hh699825.aspx)  
-->
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Security Concepts for Dynamics 365 Customer Engagement (on-premises)](../admin/security-concepts.md)  

### Roles, privileges, and access rights

Best practices for use of the Dynamics 365 Customer Engagement (on-premises) security model include the following:

- Strictly limit the number of people assigned the System Administrator role. Never remove this role.  
- Create roles according to the security best practice of least privilege, providing access to the minimum amount of business data required for the task. Assign users the appropriate role for their job.
- Create a new role with those specific privileges and add the user to the new role if a user needs additional access levels or rights. A user's rights are the union of all the roles to which he or she has been assigned. Do not grant the original role privileges that are needed by only one or several members.  
- Use sharing, when appropriate, to give specific users specific rights on individual objects, instead of broader privileges on all objects of a given type.
- Use teams to create cross-functional groups so that specific objects can be shared with the team.  
- Train users who have sharing access rights to share the minimum information needed.  

### Avoid elevation of privilege

Elevation of privilege attacks occur when a user can assume the privileges of a trusted account, such as an owner or administrator. 
Always run under least-privileged user accounts and assign only needed permissions. Avoid using administrative or owner accounts for executing code. 
This limits the amount of damage that can occur if an attack succeeds. When performing tasks that require additional permissions, use procedure 
signing or impersonation only for the duration of the task.  

### Server-side development

Best practices for developing server-side code for Dynamics 365 Customer Engagement (on-premises) include the following:

- Do not modify the Dynamics 365 Customer Engagement (on-premises) database by any means other than using the SDK because this bypasses the Dynamics 365 Customer Engagement (on-premises) security model.
- Plug-ins are running in an administrator's context – you should know that this code may access information that the logged-on user does not have access to.
- For workflow assemblies, and plug-ins, avoid writing code that takes a long time to execute. It is important that plug-in code that is registered to execute synchronously returns as quickly as possible.
- If you are replicating Dynamics 365 Customer Engagement (on-premises) data in your own data store, you are responsible for the security of the data. If you use a plug-in to transmit the data, make sure that you register the plug-in to execute after the core platform operation. Security privilege checks for the logged-on user occur during the core platform operation.
- Data that comes out of Dynamics 365 Customer Engagement (on-premises) might not be safe for rendering. Data may have been injected with HTML tags that are not secure.
- Adhere to the requirement of not accessing Dynamics 365 Customer Engagement (on-premises) databases directly through [!INCLUDE[pn_SQL_Server_short](../includes/pn-sql-server-short.md)] Enterprise Manager. Bypassing the SDK can open you up to SQL injection threats.
- For Internet facing deployments, remember that your solution is only as secure as the weakest link. After your application is exposed to the Internet, it is open to security threats.  
- Use only languages that produce managed code for the best security from buffer overruns, exceptions, and so on.

For more information about security, see the following topics:

- [Security in Visual Studio](https://msdn.microsoft.com/library/4cftbc6c.aspx)
- [Secure Coding Guidelines for the .NET Framework](https://msdn.microsoft.com/library/8a3x2b7f.aspx)
- [Securing ASP.NET Web Sites](https://msdn.microsoft.com/library/91f66yxt.aspx)

### Client-side development

Best practices for developing customizations for the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] web application and [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] include the following:

- Use web resources instead of pages that require server-side processing whenever possible. If your requirements can only be achieved by using server-side processing, adhere to the requirement that your custom webpages are installed in a separate website from Dynamics 365 Customer Engagement (on-premises). Set the trust level for your site appropriately, depending on your confidence level in the security of your code. This reduces the threat from cross-site scripting and other threats.  
- For improved security, make sure that your separate website runs on a different account from Dynamics 365 Customer Engagement (on-premises). This account should have the minimum access possible and one that does not have direct access to the Microsoft databases. You can use a complex password that doesn’t expire because no person signs in to this account – only in to your application.
- Avoid use of [!INCLUDE[pn_ms_ActiveX_short](../includes/pn-ms-activex-short.md)] controls because they have known security problems.
- Be aware of the limitations of client scripting. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Best practices: Client scripting in Customer Engagement](clientapi/client-scripting-best-practices.md)
- Use plug-ins to apply business logic regardless of how the data changes are made.
- Always use a confirmation dialog box when you delete records or apply sensitive changes, such as adding a new user to a security role. You can use  [openConfirmDialog](clientapi/reference/Xrm-Navigation/openConfirmDialog.md) to display a dialog. This helps prevent techniques such as click-jacking or UI redressing where a malicious developer may embed your page in a seemingly innocuous page to trick a user into performing actions that may compromise security or perform unwanted actions on data.  

### Security best practices for your website include the following:

- Don’t use anonymous access.  
- Use integrated Windows authentication, NTLM, or Basic authentication over Transport Layer Security (TLS) or Secure Sockets Layer (SSL).  
- Use [!INCLUDE[pn_ssl_short](../includes/pn-ssl-short.md)] to avoid sending unencrypted data over the network if your website is on a different computer than Dynamics 365 Customer Engagement (on-premises).  

  For more information, see the following:  

- [Overview of Web Application Security Threats](https://msdn.microsoft.com/library/f13d73y6.aspx)  
- [Download: Microsoft Anti-Cross Site Scripting Library V4.2](https://www.microsoft.com/download/details.aspx?id=28589)  
- [ASP.NET Web Application Security](https://msdn.microsoft.com/library/330a99hc.aspx)  
- [Introduction to Web Application Security](https://msdn.microsoft.com/library/aa711426\(VS.71\).aspx)  

<a name="ISV"></a>

## ISV extensibility best practices

One of the key tenets of ISV extensibility is that you should not assume that your ISV solution is the only one installed. The following is a list of best practices to follow.  

### Best practices for using the Dynamics 365 Customer Engagement web services

You should put the Dynamics 365 Customer Engagement (on-premises) web service URLs into a configuration file, for example, into an app.config file, so that your code is isolated from changes to the URL. For example, there are different URLs for the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] data centers throughout the world.  


### Where should you put your custom web applications or webpages?

Refer to the topic [Implement Single Sign-on from an ASPX Web Page or IFRAME](implement-single-sign-aspx-webpage-iframe.md).  

### How do you execute a plug-in when the web application’s grid view is updated?

Register the plug-in on the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> message request and do not specify any entity type during the registration.  

### When should you create a new website?

Create a new website for your code when any of the following applies:

- Your application must be bound to a domain, protocol, or port that is different from the Dynamics 365 Customer Engagement (on-premises) application; or must run in a different application pool.  
- Your application can exist and be accessed on its own. For example, a portal that interacts with Dynamics 365 Customer Engagement (on-premises) as the server (by using web services) should be hosted as a new website.
- Your application always uses [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] or integrated Windows authentication (not IFD) and cross-domain scripting is not an issue. For example, your application interacts with a back end by using web services and interacts with Dynamics 365 Customer Engagement (on-premises) form. A page hosted in an IFRAME that is enclosed in Dynamics 365 Customer Engagement (on-premises) application that does not interact with the Dynamics 365 Customer Engagement (on-premises) form falls into this category.  

### See also  
 [Write Code for Dynamics 365 Customer Engagement (Web Services)](extend-dynamics-365-server.md)   
 [Write Code for Dynamics 365 Customer Engagement (on-premises) Forms](clientapi/client-scripting.md)   
 [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)   
 [Custom Workflow Activities (Workflow Assemblies)](custom-workflow-activities-workflow-assemblies.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
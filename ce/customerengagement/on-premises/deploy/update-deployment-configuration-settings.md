---
title: "Update deployment configuration settings | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f715ab04-f78f-4bcb-b260-4807091cf7d6
caps.latest.revision: 25
ms.author: matp
author: Mattp123
manager: kvivek
---
# Update deployment configuration settings



You can use the `Microsoft.Crm.PowerShell.Get-CrmSetting` and `Microsoft.Crm.PowerShell.Set-CrmSetting` cmdlets to retrieve and update many different settings properties for your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. The `Get-CrmSetting` cmdlet retrieves a [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment setting object, such as `IfdSettings`. The `Set-CrmSetting` cmdlet updates the deployment setting.  
  
 This topic lists the setting types with their parameters. For more information about these settings, see [Microsoft.Xrm.Sdk.Deployment Namespace](/dotnet/api/microsoft.xrm.sdk.deployment?view=dynamics-deployment-ce-9). For an example of code using the `Get-CrmSetting` and `Set-CrmSetting` cmdlets see [Change monitoring settings](microsoft-dynamics-365-monitoring-service.md#BKMK_changemon).  
  
<a name="async"></a>   
## AsyncSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|JobTimeoutLockedInterval|Gets or sets the interval used to query to see if there are any organization maintenance jobs that have timed out.|Integer|  
|MaxJobExecutionTime|Gets or sets a value used for organization maintenance jobs to determine if a job has timed out.|Integer|  
|MaxRetries|Gets or sets the number of times an asynchronous job will retry before it fails or suspends.|Integer|  
|MaxStateStatusUpdateMaxRetryCount|Gets or sets the maximum number of times a database operation will be attempted before failure.|Integer|  
|OrgDatabaseMaintenanceJobInterval|Gets or sets the interval used to query to see if there is a pending organization maintenance job.|Integer|  
|RetryInterval|Gets or sets the default rate of retries for failed asynchronous operations.|Integer|  
|SdkRootDomain|Gets or sets the root domain used for calls into the Microsoft Dynamics Dynamics 365 service from the asynchronous service.|String|  
|SelectInterval|Gets or sets the interval used to determine if new asynchronous operations should be loaded into memory.|Integer|  
|ThrottlingConfiguration|Gets or sets the throttling configuration.|String|  
|TimeoutLockedInterval|Gets or sets the interval used to query to see if there are any asynchronous operations that have timed out.|Integer|  
  
<a name="claims"></a>   
## ClaimsSettings  
 For an example of code you can use to update [!INCLUDE[pn_Internet_facing_deployment](../includes/pn-internet-facing-deployment.md)] settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment, see [Configure IFD settings](configure-ifd-settings.md). The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|Enabled|Gets or sets whether or not claims is enabled.|Boolean|  
|EncryptionCertificate|Gets or sets the encryption certificate name.|String|  
|FederationMetadataUrl|Gets or sets the federation metadata URL.|String|  
|FederationProviderType|Gets or sets the federation type provider.|Integer|  
|SessionSecurityTokenLifetimeInHours|Gets or sets the security session token lifetime, in hours.|Integer|  
  
<a name="customcode"></a>   
## CustomCodeSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|AllowDeclarativeWorkflows|Gets or sets whether XAML workflows are allowed on the server.|Boolean|  
|AllowExternalCode|Gets or sets whether plug-ins and custom workflow activities can be registered on the server.|Boolean|  
  
<a name="dashboard"></a>   
## DashboardSettings  
 The following setting is available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|MaximumControlsLimit|Gets or sets the maximum number of controls allowed on dashboards for the server. The maximum number cannot exceed 20.|Integer|  
  
<a name="dup"></a>   
## DupSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|BulkDetectBatchSize|Gets or sets the bulk duplicate detection batch size.|Integer|  
|MatchcodeLength|Gets or sets the length of the match code.|Integer|  
|MatchcodePersistenceInterval|Gets or sets the persistence interval for the match code.|Integer|  
|MaxPublishedRules|Gets or sets the maximum number of published rules.|Integer|  
|PublishAsyncPollingInterval|Gets or sets the polling interval for the asynchronous job.|Integer|  
|PublishPageSize|Gets or sets the page size for results.|Integer|  
  
<a name="etm"></a>   
## EtmSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|Enabled|Gets or sets whether Enterprise Transaction Monitor (ETM) is enabled.|Boolean|  
|ThrottlingEnabled|Gets or sets whether Enterprise Transaction Monitor (ETM) throttling is enabled.|Boolean|  
  
<a name="ifd"></a>   
## IfdSettings  
 For an example of code you can use to update Internet-facing deployment (IFD) settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment, see [Configure IFD settings](configure-ifd-settings.md). The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|DiscoveryWebServiceRootDomain|Gets or sets the discovery web service domain.|String|  
|Enabled|Gets or sets a value that indicates whether Internet-facing deployment (IFD) is enabled.|Boolean|  
|ExternalDomain|Gets or sets the external domain value for Internet-facing deployment (IFD).|String|  
|IntranetAccessEnabled|Gets or sets a value that indicates whether intranet access is enabled.|Boolean|  
|OrganizationWebServiceRootDomain|Gets or sets the organization web service domain.|String|  
|WebApplicationRootDomain|Gets or sets the web application server domain.|String|  
  
<a name="import"></a>   
## ImportSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|BatchSize|Gets or sets the number of items to process in a batch.|Integer|  
|ContentBufferSize|Gets or sets the size of the content buffer.|Integer|  
|CountUpdateBatchSize|Gets or sets the batch size for import count updates.|Integer|  
|MaxColumnsAllowed|Gets or sets the maximum number of columns in an import file.|Integer|  
|MaxDataTruncationRetryCount|Gets or sets the maximum number or retries.|Integer|  
|ParsedColumnDefaultSize|Gets or sets the default size of the parsed column.|Integer|  
|PickListBatchSize|Gets or sets the batch size for picklist import.|Integer|  
  
<a name="market"></a>   
## MarketplaceSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|InternetConnectionProxyEndpoint|Gets or sets the proxy server and port used for outgoing internet requests.|String|  
|SolutionsMarketplaceEnabled|Gets or sets whether the solutions marketplace is enabled.|Boolean|  
  
<a name="monitor"></a>   
## MonitoringSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|CertificateLifetimeNotificationThreshold|Gets or sets the threshold of the certificate lifetime remaining at which to begin reporting expiration notifications.|Integer|  
|MonitoringOrganizationUniqueName|Gets or sets the unique name of the organization that will serve as the monitoring organization.|String|  
|MonitoringOrganizationUserAccount|Gets or sets the user account to access that organization.|String|  
|MonitoringOrganizationUserPassword|Gets or sets the password to access that organization.|PS-Credential|  
|ResultsToKeep|Gets or sets the maximum number of results to keep as files from the monitoring.|Integer|  
|ResultsToKeepInDatabase|Gets or sets the maximum number of results to keep in the database.|Integer|  
|StoreResultsInDatabase|Gets or sets the results to store in the database as well as files.|Boolean|  
  
<a name="multi"></a>   
## MultiEntityQuickFindSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|MultiEntityQuickFindDegreeOfParallelism|Gets or sets the maximum degree of parallelism for multi-entity search queries.|Integer|  
|MultiEntityQuickFindEntityLimit|Gets or sets the upper limit for the number of entities that can participate in a multi-entity search query.|Integer|  
|MultiEntityQuickFindMaxRequestsPerOrgPerServer|Gets or sets the maximum number of concurrent `QuickFind` requests per organization per server.|Integer|  
|MultiEntityQuickFindMaxRequestsPerServer|Gets or sets the maximum number of concurrent `QuickFind` requests per server|Integer|  
  
<a name="BKMK_OAuthClaims"></a>   
## OAuthClaimsSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|Enabled|Gets or sets whether or not claims is enabled.|Boolean|  
|EncryptionCertificate|Gets or sets the encryption certificate name.|String|  
|FederationMetadataUrl|Gets or sets the federation metadata URL.|String|  
|FederationProviderType|Gets or sets the federation type provider.|Integer|  
|SessionSecurityTokenLifetimeInHours|Gets or sets the security session token lifetime in hours.|Integer|  
  
<a name="quick"></a>   
## QuickFindSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|QuickFindEntityIndexLimit|Gets or sets the maximum number of the attributes used in the quick find search query, after which the `QuickFind` indexes are not created.|Integer|  
|QuickFindRecordLimit|Gets or sets the maximum number of records that match the quick find query criteria before an exception error is thrown. This is needed for faster execution of the quick find searches.|Integer|  
  
<a name="sqm"></a>   
## SqmSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|SqmEnabled|Gets or sets the value that indicates whether collection of information for the customer experience improvement program is enabled.|Boolean|  
  
<a name="team"></a>   
## TeamSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|MaxAutoCreatedAccessTeamsPerEntity|Gets or sets the maximum number of auto created (system-managed) access teams per entity.|Integer|  
|MaxEntitiesEnabledForAutoCreatedAccessTeams|Gets or sets the maximum number of entities that can be enabled for auto created (system-managed) access teams.|Integer|  
  
<a name="throttle"></a>   
## ThrottleSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|ExecuteAsyncMaxConnectionsPerServer|Gets or sets the maximum number of concurrent asynchronous execute operations per organization.|Integer|  
|ExecuteAsyncPerOrgMaxConnectionsPerServer|Gets or sets the maximum number of concurrent execute multiple operations per organization per server.|Integer|  
|ExecuteMultipleMaxConnectionsPerServer|Gets or sets the maximum number of concurrent execute multiple operations per organization.|Integer|  
|ExecuteMultiplePerOrgMaxConnectionsPerServer|Gets or sets the maximum number of concurrent execute multiple operations per organization per server.|Integer|  
|FollowInYammerMaxConnectionsPerServer|[!INCLUDE[internal](../includes/internal.md)]|Integer|  
|FollowInYammerPerOrgMaxConnectionsPerServer|[!INCLUDE[internal](../includes/internal.md)]|Integer|  
|MapiSyncMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of MAPI sync operations.|Integer|  
|MapiSyncPerOrgMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of MAPI sync operations per organization.|Integer|  
|MaxBackgroundSendEmailRequestsPerOrgPerServer|Gets or sets the server setting to control the maximum number of background email send operations per organization.|Integer|  
|MaxBackgroundSendEmailRequestsPerServer|Gets or sets the server setting to control the maximum number of background email send operations.|Integer|  
|MaxSharepointThreadsperOrganisation|Gets or sets the maximum number of Microsoft SharePoint threads allowed per organization.|Integer|  
|MaxSharepointThreadsperUser|Gets or sets the maximum number of Microsoft SharePoint threads allowed per user.|Integer|  
|OfflineSyncMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of offline sync operations.|Integer|  
|OfflineSyncPerOrgMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of offline sync operations per organization.|Integer|  
|OutlookSyncMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of Dynamics 365 for Outlook sync operations.|Integer|  
|OutlookSyncPerOrgMaxConnectionsPerServer|Gets or sets the server setting to control the maximum number of Dynamics 365 for Outlook sync operations per organization.|Integer|  
  
<a name="trace"></a>   
## TraceSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|CallStack|Gets or sets whether to save the call stack.|Boolean|  
|Categories|Gets or sets the categories to trace.|String|  
|Directory|Gets or sets the directory for the trace files.|String|  
|Enabled|Gets or sets whether tracing is enabled.|Boolean|  
|FileSize|Gets or sets the trace file size limit (MB).|Integer|  
  
<a name="web"></a>   
## WebAddressSettings  
 For an example of code you can use to update web address settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment, see [Configure web address settings](configure-web-address-settings.md). The following settings are available.  
  
|Name|Description||  
|----------|-----------------|-|  
|DeploymentSdkRootDomain|Gets or sets the root domain for the deployment web service (SDK).|String|  
|DiscoveryRootDomain|Gets or sets the root domain for the discovery web service.|String|  
|HelpServerUrl|Gets or sets the URL for help content server.|String|  
|NlbEnabled|Gets or sets whether network load balancing (NLB) is enabled.|Boolean|  
|RootDomainScheme|Gets or sets the root domain scheme: http or https.|String|  
|SdkRootDomain|Gets or sets the root domain for the organization web service (SDK).|String|  
|SslHeader|Gets or sets the secured sockets layer (SSL) header.|String|  
|WebAppRootDomain|Gets or sets the root domain for the web application.|String|  
  
<a name="workflow"></a>   
## WorkflowSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|MaxDepth|Gets or sets the maximum depth for a workflow.|Integer|  
|MinInactiveSeconds|Gets or sets the maximum number of seconds a workflow can be inactive.|Integer|  
  
<a name="yammer"></a>   
## YammerSettings  
 The following settings are available.  
  
|Name|Description|Data type|  
|----------|-----------------|---------------|  
|ApplicationId|Gets or sets the application ID.|String|  
|ApplicationSecret|Gets or sets the application secret.|String|  
  
## See Also  
 [Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md) </br>
 [Microsoft Dynamics 365 (on-premises) PowerShell Reference](/powershell/module/microsoft.crm.powershell/?view=dynamics365ce-ps)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
By installing and enabling the [!INCLUDE[pn_gamification_solution](../includes/pn-gamification-solution-md.md)] solution, the enabling user’s account identifiers (such as first name, last name, and email address) will be stored in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] to allow for authorization with the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] service, which is hosted in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)]. This applies to all users that are enabled in the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] service by their administrator. The [!INCLUDE[pn_gamification_solution](../includes/pn-gamification-solution-md.md)] solution sends Key Performance Indicators (KPI) data, configured by an administrator, to the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] service, and that data is stored in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] structured storage as well as blob storage.  Each user’s Avatar, Custom Awards, and Company Logo are stored in [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)], but the information is not returned to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest-md.md)].  
  
Note that administrators and authorized users can leverage [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest-md.md)] data, such as phone calls, opportunities, and booked revenue to configure KPIs for use in games. The [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] service does not initiate any calls to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest-md.md)] and only responds to data, such as games where the KPIs are being used, that flows back to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest-md.md)].  
  
An administrator can also enable the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] TV stream to be made public. Game managers who set up [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] TV streams and enable public streaming will allow for the TV stream to be viewed by anyone on the Internet who has the stream link.  
  
An administrator can subsequently remove the [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] functionality by uninstalling this solution from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm-md.md)] organization.  
  
[!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] components and services that are involved with [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] are detailed in the following sections.  
  
[!INCLUDE[cc_privacy_note_azure_trust_center](../includes/cc-privacy-note-azure-trust-center-md.md)]  
  
[Cloud Services](https://azure.microsoft.com/services/cloud-services/)  
  
 **Designer Service (Web Role)**  
  
This provides multiple Web Services for communication between a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest-md.md)] organization and the multi-tenanted [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)][!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] components.  For example, gamification details stored to [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] SQL Storage.  Game calculations use [!INCLUDE[pn_azure_service_bus](../includes/pn-azure-service-bus-md.md)] queue and returned to be scored and shown in the service.  Customer and user uploaded images are stored in [!INCLUDE[pn_azure_blob_storage](../includes/pn-azure-blob-storage-md.md)].  All requests are authenticated against [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory-md.md)].  
  
[Azure Key Vault](https://azure.microsoft.com/services/key-vault/)  
  
All services store configuration data in [!INCLUDE[pn_azure_key_vault](../includes/pn-azure-key-vault-md.md)].  
  
[Azure SQL Database](https://azure.microsoft.com/services/sql-database/)  
  
[!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] uses SQL [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] to store:  
  
- KPI data  
  
- Game calculations  
  
- Organization (tenant) data  
  
[Azure Blob Storage](https://azure.microsoft.com/services/storage/)  
  
Avatars, company logos, and other customer uploaded images are stored in [!INCLUDE[pn_azure_blob_storage](../includes/pn-azure-blob-storage-md.md)].  
  
[Azure Content Delivery Network (CDN)](https://azure.microsoft.com/services/cdn/))  
  
[!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] uses [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest-md.md)] Content Delivery Network to serve static content to the runtime such as images (including uploaded images such as customer logos), [!INCLUDE[pn_JavaScript](../includes/pn-javascript-md.md)], and CSS.  
  
[Azure Active Directory](https://azure.microsoft.com/services/active-directory/)  
  
[!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest-md.md)] uses [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory-md.md)] to authenticate users and determine eligibility to use the platform.
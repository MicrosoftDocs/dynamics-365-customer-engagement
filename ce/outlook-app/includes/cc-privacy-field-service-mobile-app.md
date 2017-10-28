By enabling the [!INCLUDE[pn_fieldservice_mobile_app_long](pn-fieldservice-mobile-app-long.md)] mobile app on a mobile device with location features enabled, real-time location data will be sent to [!INCLUDE[pn_bing_maps](pn-bing-maps.md)] and stored in [!INCLUDE[pn_dynamics_crm](pn-dynamics-crm.md)]. Users are prompted to provide permission for the flow of real-time location data during installation or use of the field service mobile app. To disable the flow of real-time location data from the device, the user must disable the device’s location features or uninstall the application.  
  
 The real-time location data sent by the field service mobile app is used to support the following scenarios:  
  
-   To show the location of a user’s customers. Data about the user’s current location is passed to the mapping provider as context for the map rendered by the provider and displayed within field service mobile app.  
  
-   To create and update a user’s schedule. Data about the user’s current location is passed to the field service capabilities in [!INCLUDE[pn_dynamics_crm](pn-dynamics-crm.md)] to create and update a user’s schedule. For example, to assign a task to the nearest technician.  
  
 In addition, by enabling the field service mobile app on a mobile device, mobile app usage information, such as application errors, will be sent to Microsoft through a secure connection to Organization Insights and stored in [!INCLUDE[pn_azure_shortest](pn-azure-shortest.md)] Table Storage.  
  
 **Note:** Organization Insights provides the system administrator of a [!INCLUDE[pn_dynamics_crm](pn-dynamics-crm.md)] organization with a quick overview of how the org is being used. The system administrator can view most active users, the number of SDK requests being initiated, and the number of being viewed by SDK users.  
  
 A list of the [!INCLUDE[pn_azure_shortest](pn-azure-shortest.md)] components and services that are involved with Help Improve [!INCLUDE[pn_unified_service_desk](pn-unified-service-desk.md)] functionality is provided below.  
  
 [!INCLUDE[cc_privacy_note_azure_trust_center](cc-privacy-note-azure-trust-center.md)]  
  
 [Cloud Services](https://azure.microsoft.com/services/cloud-services/)  
  
 **OrgInsights Data REST API (Web Role)**  
  
 This web role accepts requests from the charts that display data in Organization Insights. The API reads aggregated data from the [!INCLUDE[pn_azure_shortest](pn-azure-shortest.md)] Tables and returns it.  
  
 [Azure Blob Storage](https://azure.microsoft.com/services/storage/blobs/)  
  
 The Monitoring Agent (which runs on every scale group computer) collects the [!INCLUDE[pn_dynamics_crm](pn-dynamics-crm.md)] organization’s raw telemetry data and uploads it in Bond Format (Binary format) to [!INCLUDE[pn_azure_blob_storage](pn-azure-blob-storage.md)].  
  
 [Azure Table Storage](https://azure.microsoft.com/services/storage/tables/)  
  
 Raw telemetry data in [!INCLUDE[pn_azure_blob_storage](pn-azure-blob-storage.md)] is aggregated and stored in [!INCLUDE[pn_azure_shortest](pn-azure-shortest.md)] Table Storage, which is read by the Cloud Service.  
  
 [Azure Active Directory](https://azure.microsoft.com/services/active-directory/)  
  
 Organization Insights uses [!INCLUDE[pn_azure_active_directory](pn-azure-active-directory.md)] Service to authenticate web services.  
  
 [Azure Service Bus](https://azure.microsoft.com/services/service-bus/)  
  
 The Monitoring Agent creates and queues messages whenever it uploads data to [!INCLUDE[pn_azure_blob_storage](pn-azure-blob-storage.md)]. The CMA pipe picks up these messages to aggregate the uploaded data.
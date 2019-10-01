By enabling [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] you agree to allow flow of the data from [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] to certain [!INCLUDE[pn-azure-shortest](../includes/pn-azure-shortest.md)] services to perform some of the marketing processes. These services are collectively referred to as "[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services" and "customer-insights services," respectively.

To implement customer journeys, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must send customer journey, email, submission-form, and marketing-page definitions to the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services running on [!INCLUDE[pn_azure_service_fabric](../includes/pn_azure_service_fabric.md)]. Marketing pages are further sent to a customer's own instance of Portal capabilities for [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)].

To personalize sent emails [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must enable data flow to and from the customer-insights services. Please see below for more information about the customer-insights services. Data flow to customer-insights services includes synchronization of contacts, accounts, and possibly other entities enabled by the customer. [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services uses this data to personalize email content. The data that is included depends exclusively on the email definition.

To calculate lead score models and marketing segments, [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] must send lead score model definitions and segment definitions to the customer-insights services and to leverage profiles and interactions stored in the customer-insights services within these calculations.

To provide insights into the email and Internet interactions captured by [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services, the collected data flows from [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services to both [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] and  the customer-insights services.

If the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] Event Management integration is also enabled, then the customer-insights services synchronize events (directly), and event registrations and check-ins (via [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services, as interactions).

Data flows involving the customer-insights services include the following:

- Entity data from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to the customer-insights services ( using the regular inbound connector for customer-insights services) to provide content for email personalization, lead scoring, and segmentation (mainly contacts and accounts, but eventually also leads and events)
- Entity data from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] via [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services to the customer-insights services, to provide identifiers for interactions and insights (customer journey, marketing emails, marketing pages)
- Interactions from [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services to the customer-insights services  (email tracking, website tracking, customer journey progress)
- Interactions from [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] via [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] services to  the customer-insights services (event registrations and check-ins)
- Insights (interactions and KPIs) from the customer-insights services to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] (mainly customer journey and email send progress, and lead scoring results)
- Customer-insights apps (segmentation and widgets) from the customer-insights services directly into dedicated and sandboxed UI elements in forms of [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

### Marketing services

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] uses these Azure services, all of which are set up for you automatically as needed (and at no extra charge) when you install the Marketing app:

- Azure Data Lake Store
- Azure Data Lake Analytics
- Azure Key Vault
- Azure Service Fabric
- Azure DocumentDB
- Azure Active Directory
- Azure Storage

> [!NOTE]
> For more information about additional Azure service offerings, see the [!INCLUDE[cc_privacy_note_azure_trust_center](../includes/cc_privacy_note_azure_trust_center.md)] (<https://azure.microsoft.com/support/trust-center/>).

### Customer-insights services for [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

By using [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], you are activating the transfer of customer data into the customer-insights services for further processing. Your use of the customer-insights services might require compliance with specific privacy laws. Please direct any questions to the appropriate representative in your organization.

The customer-insights services are natively built on Azure services, and respective compliance and security standards for each applicable Azure service apply. For more information, go to the [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] Trust Center: [https://azure.microsoft.com/support/trust-center/](https://azure.microsoft.com/support/trust-center/)

The customer-insights services use these Azure services, all of which are set up for you automatically as needed (and at no extra charge) when you install the Marketing app:

- Azure Data Lake Store
- Azure Data Lake Analytics
- Azure HDInsight (Spark, Phoenix, HBase)
- Azure SQL Database
- Azure Key Vault
- Azure Secret Store
- Azure Event Hub
- Azure Stream Analytics
- Azure Redis Cache
- Azure Service Fabric
- Azure Active Directory
- Azure Monitoring
- Azure Metrics
- Azure Websites
- Azure Service Bus
- Azure Storage

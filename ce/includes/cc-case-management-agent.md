- The AI agent requires a dedicated application user to send and receive emails on behalf of your organization. Perform the following steps:
   1. [Create](/entra/identity-platform/quickstart-create-new-tenant#create-a-new-microsoft-entra-tenant) and [register a single-tenant application registration](/entra/identity-platform/quickstart-register-app#register-an-application) in the Azure portal. Copy the values of **Client ID**, **Client Secret**, and **Tenant**.
   2. [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) with Customer Service Representative role in Power Platform admin center.
   3. Create a shared mailbox in Exchange Online. Learn more in [Shared mailboxes in Exchange Online](/exchange/collaboration-exo/shared-mailboxes).
   4. Assign the shared mailbox email id to the application user in Power Platform admin center. Learn more in [Manage email settings](/power-platform/admin/settings-email). This application user is used in Copilot Service admin center to receive and send responses.
   5. In Copilot Studio, select Case Processing Agent in **Agents** and create a connection reference with the following data. Learn more in [Configure and manage connections](/microsoft-copilot-studio/authoring-connections).
       - **Authentication Type**: Service Principal
       - Specify the **Client ID**, **Client Secret**, and **Tenant** that you've copied in the earlier step.
       - Publish the agent. 
       
## Configure global settings

In Copilot Service admin center, follow these steps:

1. Select **Manage** for **Case Management Agent** in **Case settings**. The **Case Management Agent** page appears.
1. Select **Manage** for **Global settings**. The Global settings (preview) page appears.
1. Set the **Application user** to the application user created in the prerequisites section.
1. Select **Use copilot recommended template for drafting emails**. 
1. Optionally, you can set the **Default email template** dropdown to a template the AI agent uses when Copilot email template recommendations are unavailable. If you configured Copilot recommended email templates and [line-of-business segregated email templates](configure-lob-email-templates.md), the system uses the default email template when no line-of-business email template is available for the case. 
If you don't select a default template and Copilot recommended email templates is configured, once the agent identifies the intent, it sends emails using the [Copilot inline email assist capabilities](/dynamics365/contact-center/use/use-copilot-email#use-copilot-to-draft-an-email).
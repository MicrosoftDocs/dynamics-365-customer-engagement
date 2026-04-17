> [!IMPORTANT]
> From June 2026, usernames and a new customer identifier called the Business-Scoped User ID are being released for WhatsApp. For updates on the timeline for this change, refer to [WhatsApp Business-Scoped User IDs](https://developers.facebook.com/documentation/business-messaging/whatsapp/business-scoped-user-ids/) in the Meta documentation.
> A Business-Scoped User ID will be assigned to every WhatsApp user that interacts with your organization. When a user adopts a WhatsApp username, their phone number will no longer be sent, and their Business-Scoped User ID will act as the primary identifier.
> With this change, the Contact Book will be enabled by default for your business WhatsApp account. By keeping your Contact Book enabled, you will preserve your ability to identify customers by phone number even after they adopt a username. If you disable the Contact Book, the phone number will be permanently lost as an identifier for the WhatsApp customer.
 
After a customer’s phone number is no longer available, their first and last name will be displayed if they are linked to a contact record. If there's no linked contact, the customer will appear as "Visitor."

### What action do I need to take?

- Review your routing rules. Any custom routing rules that have conditions on phone number patterns like country/region code–based routing will not match Business-Scoped User ID-only conversations. Add a fallback rule to ensure these conversations are routed correctly. Business-Scoped User ID will be prefixed with two-letter country code and a period, followed by up to 128 alphanumeric characters (for example, US.13491208655302741918)
- Review any integrations or automation workflows like Power Automate flows that rely on phone numbers for customer identification and update them to handle Business-Scoped User ID. 
- Review context variables in your AI agents. If you are using msdyn_CustomerPhoneNumber in your AI agent configuration, update your logic to also handle scenarios where the Business-Scoped User ID only is available.
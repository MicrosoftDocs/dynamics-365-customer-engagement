---
title: Use GDPR features
description: Learn how to use GDPR features in Dynamics 365 Marketing.
ms.date: 07/07/2023
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Outbound marketing compliance settings

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

This article describes how to enable and use GDPR-related features in Dynamics 365 Marketing for Outbound Marketing.

## Outbound consent

Outbound marketing has a different consent model than real-time marketing. Real-time marketing's consent model, however, doesn't affect outbound marketing functionality. In other words, if you install real-time marketing, all of outbound marketing's features and requirements are left intact.

Learn more about outbound marketing's consent model: [Data protection and the GDPR](gdpr.md)

After you install real-time marketing, you'll notice a slight change in the settings related to the GDPR configuration. To enable the GDPR configuration, go to **Settings** > **Compliance profiles** > **Outbound consent**.

> [!div class="mx-imgBorder"]

> ![Configure outbound consent screenshot.](media/real-time-marketing-outbound-consent.png "Configure outbound consent screenshot")

By default, both switches are turned off. If you had a GDPR configuration enabled before, the system respects your previous settings.

In outbound marketing, you can configure each customer journey (and lead scoring model) to only process contacts that have given a minimum required level of consent. To enable this consent control, activate the **Enable the minimum consent level selection drop down** switch.

The second switch, **Log consent changes for this field**, enables logging of contact attribute *Consent given* changes.

After making changes to the **Outbound consent** settings, select **Save** in the top-left corner of the window.

### Use outbound consent in customer journeys

To use this feature in customer journeys:

1. Gather consent from your end users. Consent should be captured in the *Consent given* field.
1. Set a minimum consent level for the customer journey.

You can find the audit data for the *Consent given* field in a user's contact record.

## View and set the consent level for each contact

When GDPR is enabled, you can view and set data-protection options for each contact. To work with them, open a contact record, go to its **Details** tab, and then scroll down to find the **Data protection** section.

> [!div class="mx-imgBorder"]
> ![Data protection settings for contacts.](media/gdpr-contact2.png)

The following settings and information are available here:

- **Consent given**: Read or set the maximum consent level granted by this contact. This contact will only be able participate in marketing initiatives permitted for this consent level or lower. You should only change this setting after receiving explicit consent from this contact. Usually, you should allow contacts to change this themselves using a subscription center.
- **Is a child**: Mark this box to indicate that this contact is a minor (usually, under 18 years old), and therefore requires extra protection.
- **Parent or custodian**: If the contact is a child, then select their legal parent or custodian (guardian) in this lookup field. The parent or custodian must also be saved as a contact in your database.
- **Tracking**: Choose whether to track contact interactions. If the box is set to **Do Not Allow**, Marketing won't track public interactions (email opening, email clicks). The tracking option allows contacts to specify whether they consent to having their interaction data saved. You can trigger this field by either adding the field to client consent forms or by updating the contact data directly.

## Filter segments by consent

You can filter segments by consent level just like you can when filtering by other contact values. Use the **Consent Given** field of the **Contact** entity to filter by consent level.

> [!div class="mx-imgBorder"]
> ![Filter a segment by consent level.](media/gdpr-segment2.png)

## Set the minimum required consent level for a customer journey

You can set the minimum consent level for any customer journey. When set, the journey processes only contacts of that level or higher. To do this, open the journey, go to its **General** tab, and set the **Minimum consent** field to the appropriate level.

> [!div class="mx-imgBorder"]
> ![Set the minimum required consent level for a customer journey.](media/gdpr-jouney3.png)

> [!NOTE]
> The minimum required consent level cannot be changed for live journeys.

## Set the minimum required consent level for lead scoring models

You can set the minimum consent level for any lead-scoring model. When set, the model scores only leads that are associated with contacts who have granted that consent level or higher.

To do this, open the lead scoring model, go to the **Summary** tab, and set the **Minimum consent** field to the appropriate level.

> [!div class="mx-imgBorder"]
> ![Set the minimum required consent level for lead scoring models.](media/gdpr-jouney3.png)

## Include a consent selector in a subscription center

A subscription center is the best place to enable contacts to confirm and modify their consent level. To set this up:

- Set up a marketing form field that maps to the GDPR consent field of the contact entity.
- Create a marketing form of type subscription-center that includes the GDPR consent field.
- Create a marketing page of type subscription-center that includes that form.

You can now create a marketing email message that includes a link to your subscription-center page. Make sure your page explains why granting consent is important and how it offers value to the individual.

> [!IMPORTANT]
> Subscription lists are managed at the *contact* level. If multiple contacts share the same email address, only the specific contact who opted out will stop receiving communications. Other contacts using the same email address will continue to receive communications. If you require opt-outs to be processed at the email level, you will need to create custom processes. More information: [Manage subscriptions at an email level](set-up-subscription-center.md#manage-subscriptions-at-an-email-level).

## Set up double opt in to confirm changes in consent level and subscriptions

To fully comply with the GDPR (and other common regulations), you must set up the double opt-in system. Double opt-in uses email messaging to ensure that all requests to change a contact's consent level or add a subscription were made on purpose by a person who can read that contact's email.

More information: [Set up double opt-in for new subscriptions and consent changes](double-opt-in.md)

> [!NOTE]
> Double opt-in is not currently supported in real-time customer journeys.

## An example of how to support data requests from your marketing audience

Under GDPR, individuals have the right to submit several types of data requests to your organization. These include requests to access, correct, erase, and transmit (in a readable format) their personal data. Dynamics 365 Marketing is a flexible and versatile system, so there are many ways to build GDPR-compliance features into it. This section provides a few examples of how to do this, but the methods you choose will depend on how your organization is structured, how it uses Dynamics 365 Marketing, and which types of customizations are in place.

### Set up a customer journey for accepting GDPR requests

One way to make it easy for individuals to submit GDPR requests to your organization could be to publish a page on your website that provides relevant details to your customer and includes links for each type of request (send me my data, update my data, and delete my data). Each of those links would bring the customer to a different marketing page, which provides:

- Further information about the specific type of request and what the customer can expect upon submitting the form.
- All the input fields required to uniquely identify the contact in your database. This is typically their email address and last name, but the actual requirements depend on your de-duplication settings.
- Any additional fields that might help your privacy officer fulfill the request (such as a field for general notes and comments or check boxes with special options).

Then prepare a single customer journey with three parallel pipelines, one for each request type. You could set up each pipeline as follows:

1. Start with a marketing form designed to collect information relevant to the request type. When a contact submits this form, they begin traveling on that path of the journey.
1. Continue to a **Task** tile, which is configured with a task-activity template that identifies the request type (update, send, or delete) and assigns a task to the security officer responsible for responding to the request. The task includes a link to the contact record, so the officer can easily go there to read the full content of the page submission.
1. End with an email message, which informs the customer that their request was received and provides additional links and instructions (such as a subscription center link), depending on the type of request.

> [!div class="mx-imgBorder"]
> ![Example customer journey for handling GDPR requests.](media/gdpr-example-journey2.png)

The remaining subsections offer more details about how this example solution could be completed to support each type of request.

### Respond to get-my-data requests

The following list provides a few ideas for how your organization could set up a system for responding to get-my-data requests. The solution you choose will depend on how your system is set up and which types of customizations are in place.

- Instruct your privacy officer to use the standard search functionality to identify relevant data and then use the built-in export capabilities to generate an Office document. No custom development is required to allow this, but for a heavily customized system it could prove to be impractical.
- Create a custom solution based on the dedicated API in Dynamics 365 that loads all the relevant information from the back-end system and assembles it into a single, portable document. This would require some custom development, but the result could provide a faster and easier solution for your privacy officer to use. More information: [Retrieve interactions for a contact using code](developer/retrieve-interactions-contact.md)
- Set up a custom reporting solution in Dynamics 365 Marketing.
- Create a new Power BI report that loads the relevant data from your Dynamics 365 Marketing organization database.

### Respond to forget-me requests

Ideally, you should prepare your system to make it easy for your privacy officer to completely delete a contact and all their related data on request.

- For a non-customized system, your privacy officer can just use the standard search function to find the contact and then hard-delete the contact. The system will automatically unlink and remove all related interaction data stored in Dynamics 365 Marketing back-end systems (including from all marketing services).
- If you have custom fields or entities, then you must further customize your system to make sure it deletes all related personal data from related records and/or unlinks them from the contact record so that all personal information is removed. More information: [Developer Guide (Marketing)](developer/marketing-developer-guide.md)

> [!NOTE]
> All data entered into a forward-to-a-friend form is automatically deleted after 30 days, so no new contact or lead records are created unless a recipient of the forward chooses to register with your organization using a landing page.

### Respond to update-my-data requests

One way to prepare your system to handle update-my-data requests could be to set up the following:

1. For the update-my-data landing page, be sure to include both the required contact fields and a general comment field where the customer can describe their request, if needed.
1. Prepare a subscription center page that has as many editable contact fields as would be safe to provide. This enables each customer to update their own information as much as possible.
1. For the marketing email message sent to the contact after submitting the form, include a link to that subscription center and include information about what to do if the customer wants to update information that isn't included on that form.

As mentioned earlier, when a privacy officer receives the task generated by the customer journey, they can select the included link to open the relevant contact record, open the insights for that record and then go to the **Marketing form interactions** tab, where they can read the full content of the form submission (for example, as a tooltip for the relevant **Form submission** value in the **Form visited list**). If needed, the privacy officer can contact the customer directly to resolve any of the special requests (such as to update data not provided on the subscription center form).

### Secure and control access to personal information

Part of the GDPR regulations is a requirement that your organization takes steps to secure and control access to personal information that is stored in your database. You can use the standard field-level, form-level, and entity-level security controls to make sure that only authorized users, who know how to handle it legally, will be able to access it. Here are some examples of data that you may need to protect:

- **Contact records:** Contact records contain many types of basic, personal data, such as names, addresses, email, phone numbers, and more. You can control access to these records by assigning entity permissions as part of each security role definition.
- **Marketing insights:** Marketing insights can include details such as website browsing records, form submissions, event attendance, and more.  Some, but not necessarily all, users that have access to contact records may be granted access to view this information. You can control this access by assigning security groups at the form level.
- **Fields with especially sensitive information:** Your contact records may include data fields with especially sensitive information, such as financial, medical, or political affiliation details. Some, but not necessarily all, users that have access to contact records may be granted access to view this information. You can control this access by assigning security groups at the field level.

For more information about how to work with the security groups and other security features in Dynamics 365, see [Security in Microsoft Dataverse](/power-platform/admin/wp-security).

## Demonstrate GDPR compliance

From time to time, you may be asked to demonstrate that your organization complies with the GDPR regulations. Dynamics 365 Marketing provides several tools to help you do this.

### Record and view justifications for consent-level changes made by users

Usually you should allow contacts to set their own consent level using a marketing page or subscription center. However, Dynamics 365 Marketing users can also  change the consent level for any contact by editing the contact record directly. You might typically do this following a telephone conversation during which the contact provided or withdrew consent. When you do manually change the consent level for any contact, it's good practice to add a comment about what you've done and why.

To add a comment about why you changed the consent level of a contact, or to review the existing comments:

1. Open the target contact record.

1. Select the **Related** tab to open a drop-down list of related record types and then select **GDPR consent change records** from the drop-down list. A list of GDPR consent change records opens as a new tab for the contact record. These records are created automatically when there's a consent level change.

1. If you'd like to export this list, select the **Export** button on the command bar.

> [!div class="mx-imgBorder"]
> ![Screenshot of GDPR consent change records.](media/gdpr-inspect-consent-changes.png)

### Enable auditing to log all record changes

Dynamics 365 can keep a record of all database changes, who made them, and when. You can use this to show when GDPR consent was changed for each contact and by whom. The auditing system is usually disabled by default, so you need to set it up if you want to use it log your GDPR consent changes (and other information). When setting up the system, you are able to choose which types of events you want to audit on which type of records.

To access the auditing features:

1. Open the **Settings** menu ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The advanced-settings area then opens in a new browser tab. This area uses a horizontal navigator at the top of the page instead of a side navigator.
1. Navigate to **Settings** > **System** > **Auditing** to open the **Audit** page. From there, you can access the auditing settings and review the audit record.

This feature is part of the standard functionality of Dynamics 365. For information about how auditing works, how to set it up, and how to review the log, see [Audit data and user activity for security and compliance](/power-platform/admin/audit-data-user-activity).

### View the audit history to find consent-level changes for a contact

Once you've enabled auditing for contacts, you are able to view a record of changes for any contact by doing the following:

1. Open the target contact record.

1. Select the **Related** tab to open a drop-down list of related record types and then select **Audit history** from the drop-down list. A list of change made to the current contact record opens as a new tab.

1. To view consent changes only, set **Filter on** to **Consent given**.

> [!div class="mx-imgBorder"]
> ![Filter audit history by consent given.](media/gdpr-audit-history2.png)

### See also

[Manage user compliance settings](real-time-marketing-compliance-settings.md)  
[Work with data protection and GDPR](privacy.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]

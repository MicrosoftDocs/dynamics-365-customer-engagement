---
title: "Set up form double opt-in (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to set up form double opt-in to let contacts confirm new subscriptions in Dynamics 365 Marketing."
ms.date: 04/23/2020
ms.service: dynamics-365-marketing
ms.custom:
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Set up double opt-in on a per-form basis

Instead of enabling [global double opt-in](double-opt-in.md), you can choose to require double opt-in on a form by form basis. Form double opt-in allows customers to select multiple subscription lists and opt-in through a single confirmation email. Form double opt-in results in many benefits:

- You can send different confirmation messages for a newsletter subscription versus a whitepaper request (when the customer uses different forms)
- You can send different confirmation messages for different languages (when the customer uses different forms)
- You can choose which forms require in double opt-in

This article describes how to enable and use form double opt in.

> [!NOTE]
> When enabled, form double opt-in takes precedence over global double opt-in settings. If both global and form opt-in are enabled, only form double opt-in will be used.

## Create a subscription confirmation-request message

1. Go to **Marketing execution** > **Marketing emails** to open the marketing email list view.

2. Select **New** to create a new message.

3. In the **Select an email template** window, go to the **Filter** tab, select the **Purpose** dropdown, and choose **Double opt-in, email base confirmation** from the drop-down list there.

4. Select the **form-doubleoptin** (or another template created by your organization for this purpose), which is already prepared with the following content:

   - Default content that includes Handlebars expressions to place the recommended dynamic content.
   - A confirmation button preconfigured with the required target URL (as a Handlebars expression).
   - The **Content type** set to **Confirmation request**.
   - The **Legal designation** set to **Transactional**.

     > [!NOTE]
     > The show-as-webpage feature doesn't work with confirmation-consent messages, so it's not included in the template and you shouldn't try to add it.

5. Customize the message as required.

6. Check for errors and go live.
    > [!NOTE]
    > You can't use the **Test Send** button to send yourself a test message when you are designing a confirmation-request message. To test your message design, set up a test subscription page and try to sign yourself up for a mailing list.

The Handlebars expressions are placeholders for dynamic values that will resolve independently each time the message is sent. The following Handlebars expressions are available for form double opt-in:

- **{{SubscriptionListNames}}**: This is a mandatory field. SubscriptionListNames resolves to show a bullet list of subscription list names that the customer checked during form submission.
- **{{ConfirmationUrl}}**: This is a mandatory field. ConfirmationUrl generates the link that the user clicks to confirm double opt-in. It is important to note that no contact or lead information about the customer is created until the confirmation button in the email is clicked, confirming that the customer has opted to join at least one subscription list.
- **{{FormDoiSubmission}}**: This is an assist edit dynamic entity used for form double opt-in.

More information: [Email marketing overview](prepare-marketing-emails.md), [Set up subscription lists and subscription centers](set-up-subscription-center.md)

## Create a form to consent to

1. Go to **Marketing** > **Internet marketing** > **Marketing forms** to open the marketing forms list view.

2. Select **New** to create a new form.

3. In the **Marketing form templates** window, go to the **Filter** tab, and select the **Purpose** dropdown. You can choose any **Form type** except **Forward to a friend**.

4. In this example, we will select the **chania** template to create a simple landing page.

5. Go to the **Toolbox** tab and add any **Subscription lists** by dragging and dropping any list name into the form.

6. Click on the **Summary** tab at the top of the editor.

7. Go to **Form level double opt-In** > **Enable double opt-In** and set the toggle to **Yes**.

8. Under **Confirmation email**, choose the confirmation-request email message you created in the previous section. 

9. Choose the **Content settings**. Unless otherwise needed, you can choose **Default Content Settings**.

10. **How to say thank you** allows you to choose which page opens after the customer clicks the confirmation button in the email. You can choose a marketing page, or you can choose a custom webpage. If you choose the **Open the marketing page after confirmation** option, select which page to open under the **Marketing Page** section. Thank you marketing page templates are provided out-of-the-box to help get you started. If you choose the **Open the web page after confirmation** option, enter a URL in the **Thank you Web Page** section.

11. Check for errors and go live.

12. You can use your newly created form on a marketing page or [embedded on an external website](embed-forms.md).

> [!IMPORTANT]
> If you use form double opt-in, contact information is not stored until _after_ the customer confirms the opt-in via email. This means that any action (such as a customer journey) that relies on contact information stops for that customer until the the customer opts in.

### See also
[Global double opt-in](double-opt-in.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
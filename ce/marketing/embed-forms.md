---
title: "Integrate Dynamics 365 for Marketing with forms published on an external website (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to publish a form on an external site and capture the submissions in Dynamics 365 for Marketing"
keywords: marketing form, embed
ms.date: 04/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 8c8063dc-3d69-46f3-9e11-722098542777
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Integrate with forms published on an external website

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] provides a complete solution for designing, publishing, and hosting your landing pages on a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] portal running on your [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] instance. However, you can also create or embed forms on your own website that submit values back to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. Marketing forms that you publish in this way function similarly to native [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] landing pages, so they will generate contacts and/or leads in your database when submitted. However, a few limitations apply, depending on how you implement the external forms.

There are two basic methods for integrating an external form with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]:

- Embed a Dynamics 365 for Marketing from on an external page
- Use form capture to integrate a form created externally

The following table summarizes the capabilities available with each of these approaches.

|   | Embedded marketing form | Captured external form | Native marketing page |
| --- | --- | --- | --- |
| Designed using the Dynamics 365 for Marketing designer | Yes | No | Yes |
| Designed using external CMS and other tools | No | Yes | Yes |
| Form prefill | Yes | No | Yes |
| Subscription center functionality | Yes | No | Yes |
| Forward to a friend functionality | Yes | ???? | Yes |
| Link to forms from email messages | Yes | Yes | Yes |
| Launch inbound campaigns | Yes | Yes | Yes |
| Uses form visits or submissions as criteria for journey triggers | Yes | Yes | Yes |
| Requires Dynamics 365 portal | No | No | Yes |
| Requires external website | Yes | Yes | No |
| Generate leads and/or contacts | Yes | Yes | Yes |
| Match and update leads and/or contacts | Yes | Yes | Yes |

## Embed a Dynamics 365 for Marketing from on an external page

To set up a form created in Dynamics 365 for Marketing for use on an external website:

1. In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], go to **Marketing** > **Internet marketing** > **Marketing forms**.

2. Create the form and add the required fields to it as usual.

   - Configure all [field elements](content-blocks-reference.md#form-content-elements) just as you would with standard marketing forms.
   - Make [layout and style settings](design-digital-content.md#work-with-the-designer) just as you would with standard marketing forms.
   - You can use CSS on your external page to further style the imported marketing form. When you're done designing your form in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], open its **Designer** > **HTML** tab to see the CSS classes assigned to each element.

3. Save the form.

4. On saving the form, a **Form hosting** tab appears. Open it.

5. In the column on the left, select **Add new form page**. A quick-create flyout slides in. (A _form page_ is a virtual page where you can make a few extra configuration settings for forms that will be embedded externally.)

6. Use the quick-create form to set up your form options. The settings here are the same as those for a [form element](content-blocks-reference.md#the-form-element-for-marketing-pages) placed on a [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] marketing page.

7. Select **Save** to create the new form page and go back to the **Form hosting** tab for your form.

8. In the column on the right, select **Add new form whitelist rule**. A quick-create flyout slides in.

9. In the **Name** field, enter the domain name of the website where you will host the form. You can whitelist as many domains as you want, but your form will only work on those domains that you whitelist.

10. Select the form page name in the left column to open its settings and view the embed code.

11. Copy the embed code and paste it onto the page of your website where you want to use it.
     > [!NOTE]
     > Depending on what type of web server and CMS system you are using, you may need to adjust the code (for example, by escaping some special characters), or adjust your system settings to allow scripts such as this one to be pasted in. See your web server and CMS documentation for details.

## Use form capture to integrate a form created externally


## Enable prefilling on hosted forms

Form prefilling enables your forms to include prefilled values for known contacts. Prefilling makes your forms easier for contacts to use and can therefore help to increase your submission rates. The feature uses cookies to identify contacts that have previously submitted a form or opened a subscription center using a personalized link sent in email.

Because form prefilling requires the form to fetch contact values from your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] database, a few extra security measures are in place to help protect contacts' privacy. This means that contacts need to opt-in for form prefilling and that you must authenticate each domain where you'll use the form. The solution only allows prefilled values to be shown to contacts whose contact record has the _allow-prefill_ flag set. Contacts can set or clear their allow-prefill flag themselves using a landing any page form, provided the form includes the setting. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] users can also edit a contact record directly to edit this setting for that contact.

To create a form with prefilling that you can embed on an external website:

1. Set up domain authentication for the external domain (website) where you will host your form and be sure to mark the **Enable prefilled forms** check box. You don't need to also enable email authentication on that domain, but you can. For instructions, see [Authenticate your domains](marketing-settings.md#authenticate-your-domains) (note that the **Enable prefilled forms check** box isn't mentioned in that topic yet because this is preview functionality, but other than that, follow the procedure provided there to generate your authentication key and register it with DNS for your external domain).

    ![Enable prefilling on an authenticated domain](media/authenticated-domains-prefill.png "Enable prefilling on an authenticated domain")

1. Create a form with the required fields and design elements as described in [Create, view, and manage marketing forms](marketing-forms.md).

1. Enable prefilling for the form as described in [Enable prefilling for forms](form-prefill.md).

1. Save the form and then go to the **Form hosting** tab (first available on save) to set up a _form page_ for it as described in [Embed a marketing form on your own website](embed-forms.md). Note that you don't need to setup a whitelist on the **Form hosting** tab (as described in the linked topic) because you've already authenticated your external site, which provides even better security than the whitelist provided here.

1. As described in [Embed a marketing form on your own website](embed-forms.md), copy the JavaScript code generated for the new form page and paste it onto a web page or CMS page for your website.

## Embed a subscription center as a hosted form

You can embed a subscription center form on an external site just as you can a standard landing page form. The only difference is that you must set the **Form type** to **subscription center**. Then authenticate your external domain, set up the form, and embed the generated form code on your page as described in the previous section.

## Reference hosted forms in emails and customer journeys

Once you have a hosted form set up, you're ready to start using it in your marketing emails and customer journeys.

### Link to a hosted form from an email message

Unlike local landing pages, there is no [design element](content-blocks-reference.md) dedicated to external forms. Therefore, use either a button element or a standard text link to link to your embedded form using its page URL from your webserver.

### Use hosted forms with journey triggers

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] now includes a _marketing form_ tile for customer journeys. It works just like the marketing page tile, both to enable customer journey triggers to react to form visits and submissions, and to create inbound campaigns (as described in the next section).

To set up a journey that invites contacts to visit an externally hosted form and then reacts to form visits and/or submissions:

1. Create and go live with a [marketing email message](prepare-marketing-emails.md) that includes a link to the page where you are hosting the form.

1. Create a customer journey as usual.

1. Start the journey with a segment that targets the contacts you want to invite to visit your landing page.

1. At the location where you want the journey to send the message, add a **Marketing email message** tile that references your message.

1. Drag a **Marketing form** tile from the **Toolbox** onto your **Marketing email** message tile to add the form as a child of that message. Then follow this message tile with a **Trigger** tile.

    ![Marketing-form and trigger tiles](media/journey-host-form-trigger1.png "Marketing-form and trigger tiles")

1. Expand the Marketing email message tile to see the **Marketing form** tile you just added to it. Select the **Marketing form** tile, open the **Properties** panel, and configure it to reference the form record that created the JavaScript (form page) you have embedded on your external site.

    ![Assign a form page to the form tile](media/journey-host-form-trigger2.png "Assign a form page to the form tile")

1. Select the **Trigger** tile and open its **Properties** panel.

1. Select **New** next to the **Set rules** heading in the trigger properties.

    ![Trigger properties](media/journey-host-form-trigger3.png "Trigger properties")

1. A new rule is added to the trigger. Set the **Source** to the name of the **Marketing form** tile that you added to the **Marketing email message** tile, and set the **Condition** to **Marketing form visited** (to trigger when a contact loads the form) or to **Marketing form contact registered** (to trigger when a contact submits the form).

    ![Conditions for a form-based trigger](media/journey-host-form-trigger4.png "Conditions for a form-based trigger")

1. Continue designing your customer journey as required.

1. Save and go live.

## Use hosted forms with inbound campaigns

You can create an inbound campaign by placing a **Marketing page** tile at the start of a journey, and then configure the tile to reference the form record that created the JavaScript (form page) you have embedded on your external site. This will cause each contact that submits the form to be added to the journey, just as though they had joined a segment targeted by the journey. You could already [do something similar for marketing pages hosted on a Dynamics 365 portal](create-inbound-customer-journey.md), but now you can also do it with an externally hosted marketing forms.

![Inbound campaign from a hosted form](media/journey-host-form-trigger5.png "Inbound campaign from a hosted form")
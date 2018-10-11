---
title: "Embed a Dynamics 365 marketing form on an external website (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How to embed a marketing form created in Dynamics 365 on a page on an external website in Dynamics 365 for Marketing"
keywords: "marketing form, embed"
ms.date: 09/17/2018
ms.service: 
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
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

# Embed a marketing form on your own website

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] provides a complete solution for designing, publishing, and hosting your landing pages, but you can also embed [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] landing-page forms on your own website using your usual web-publishing tools. Marketing forms that you publish in this way function just as they would when embedded on the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] landing page, so they will generate contacts and/or leads in your database when submitted.

> [!NOTE]
> You can't embed subscription center or forward-to-a-friend forms in external pages. For these, you must use a native [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] marketing page.


> [!NOTE]
> You can't assign external pages to marketing-page tiles in customer journeys. That means that you must use native [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] marketing pages for inbound campaigns, and if you want a customer-journey trigger to react to landing-page clicks and submissions. However, you *can* create a marketing email that includes a standard link to an external landing page and then set a customer-journey trigger to react to link clicks from that message.

To set up a form for use on an external website:

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
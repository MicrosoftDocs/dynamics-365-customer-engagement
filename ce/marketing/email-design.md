---
title: "Create and design a marketing email message (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Learn how to create and design a marketing email message in Dynamics 365 for Marketing"
ms.date: 08/21/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: 8f419f3b-5a43-4446-856e-48a1d83fbe57
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

# Create a new email and add content

Read this topic to learn how to create an email message and design its content. See also the [email marketing overview](prepare-marketing-emails.md) for a summary of the full message creation, delivery, and analysis process for email marketing. 

For a step-by-step tutorial for how to create and send your first marketing email message, see also [Create a marketing email and go live](create-marketing-email.md)

## Create a new email marketing message

To create a new email marketing message, go to **Marketing** > **Marketing Execution** > **Marketing emails** and select **New** on the command bar. Y See the remaining sections of this topic for details. 

![Location of the new-email button](media/new-email-button-location.png "Location of the new-email button")

## Establish your basic layout by choosing the right template

The first thing you are asked when you create a new message is to selected a template. Dynamics 365 for Marketing includes a wide variety of templates, each of which includes both structural and style elements; there's also a blank template, which lets you start from scratch wiht an empty message. On selecting a template, you'll be in the email designer, where you can finish creating your email content.

![Dialog for choosing an email template](media/email-template-dialog.png "Dialog box for choosing an email template")

When you create a new message from a template, the template content is copied into your new message. The message and template aren't linked, so when you edit the message, the template won't change; likewise, any future changes that you make to a template won't affect any existing messages that were created by using it.

You can also create your own custom templates, which can help both you and others in your organization to create new messages more quickly in the future. Design your templates so that they reflect your organization's graphical identity and fit closely with the types of campaigns you run most regularly. You can save any existing message as a template by selecting **Save as template** on the command bar, or work directly in the templates area (**Marketing** > **Marketing Templates** > **Email templates**) to view or edit existing templates and create new ones. When setting up a template, you can add various types of metadata (such as purpose, style, market type, and optimized for) which make each template easier to identify and easier to find by using filters.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with email, page, and form templates](email-templates.md)

## Design your content

After choosing a template, you'll be in the email content designer, which resembles the other [digital content designers](design-digital-content.md) provided in Dynamics 365. Work with it as follows:

- Use the **Design** &gt; **Designer** tab graphical tool to design your content by using drag-and-drop, point-and-click operations. Add new elements to your design by dragging design elements from the **Design** &gt; **Designer** &gt; **Toolbox** tab to the canvas. Choose a design elements that already exists in your design, and then open the **Design** &gt; **Designer** &gt; **Properties** tab to configure it and style it. To style the overall message with basic fonts, colors, and background, open the **Style** tab.

- When you select a design element on the canvas, you'll usually see a formatting toolbar just above the element. The controls offered by the toolbar vary depending on which type of element you've selected. Most toolbars provide buttons to move, copy, or delete the selected element, in addition to specialized buttons that vary by element type.

- When a text element is selected, you'll get a full formatting toolbar that you can use to apply basic text formatting like you would in [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)]. It also includes an **Assist Edit** button **&lt;/&gt;**, which you can use to add dynamic content such as a mail-merge field that displays the recipient's name. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use assist-edit to place dynamic field values](dynamic-email-content.md#assist-edit)

- Use the **Designer** &gt; **HTML** tab to edit the raw HTML directly. You might use this to paste in an existing HTML design, or to fine-tune the code in ways that aren't supported by the graphical editor (such as custom attributes or logic). The HTML editor has two subtabs: **HTML Source** (for editing the design, including logical expressions and dynamic content) and **HTML Output** (which resolves all dynamic content to provide static HTML that you can use in other applications).

![Add a text element to a new email](media/email-add-text-block.png "Add a text element to a new email")


[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design your digital content](design-digital-content.md)

> [!IMPORTANT]
> When you're designing email content, you should always try to minimize the size of your messages as much as you can. When it comes to the text and code content (not including referenced image content), we recommend that you always keep your files under 100 KB for the following reasons:
> 
> - Emails larger than 100 KB are often flagged as spam by spam filters
> - Gmail truncates messages after the first 102 KB of source text and coding.
> - Emails larger than 128 KB can't be delivered by a customer journey (the journey will [fail its error check](#go-live-journey) if it includes messages larger than this)
> - Large emails take longer to load, which may annoy recipients.

> [!NOTE]
> Microsoft Outlook supports local customizations and plugins that can affect the way messages are rendered. In some cases, recipients using customized Outlook installations may see odd layouts or repeated page elements when viewing pages designed in Dynamics 365 for Marketing. These effects can't be simulated by the designer. If necessary, you can use [test sends](#preview-message) to see how your designs look in specific Outlook configurations.

<a name="required-links"></a>

## Add standard, required, and specialized links to your message

Marketing messages are delivered as HTML and therefore support hyperlinks. Some types of links provide access to special features that are hosted by Dynamics 365, whereas others can simply be standard links to content anywhere on the web. A subscription center link is required before any message can pass the error check and go live, but other links are optional, so you can use them only as needed. 

The following list describes the types of links that are available. You'll use the [assist-edit](dynamic-email-content.md#assist-edit) feature to add most types of dynamic links as text in a text element, while other types of links are added by using a dedicated design-element type (such as an event element).

- **Standard links**: You can add standard links to any text content by highlighting the link text and selecting **Link** on the text toolbar. You can also add link URLs to many other types of design elements, including images and buttons. When your message goes live, Dynamics 365 replaces each link with a unique redirect URL that targets your Dynamics 365 server and identifies the message recipient, message ID, and the destination you specified for the link. When a contact clicks a link, Dynamics 365 logs the click and then forwards the contact directly to the URL you specified.
- **Event, survey, or landing page**: These links go to an event website, survey, or landing page. You can add them as text links in a text element, or as colorful call-to-action buttons. To create a button, drag an event, survey, or landing-page element to your email design and then configure which item the element should link to. To create a text link, select some text in a text element and then use the [assist-edit](dynamic-email-content.md#assist-edit) feature.
- **Subscription center (required)**: All marketing email messages must include a link to a subscription center. A subscription center includes mailing lists available from your organization, including an option for contacts to opt out of all marketing emails. Contacts might also be able to update their contact details here. Dynamics 365 includes a standard subscription center, which you can edit to contain your subscription lists and to reflect your graphical identity (you can also create additional pages to support multiple subscription options, languages, or brands). You'll add a subscription center link to your page by highlighting the link text and selecting **Link** on the text toolbar, and then using the [assist-edit](dynamic-email-content.md#assist-edit) feature to select the subscription center URL from the content settings.
- **Forward to a friend**: This type of link opens a form that contacts can use to forward a marketing email to their own friends or colleagues by entering recipients' email addresses. It's a good idea to include this type of service for your contacts because messages forwarded by using the forward form are counted correctly in your email results and analytics (messages forwarded by using a contact's local email client forward feature won't be registered in Dynamics 365, and all message opens and clicks performed by the recipients who were forwarded the message will be credited to the original recipient). A forward-to-a-friend page ID can be included in each set of content settings, but none is provided out of the box, so you must create a forwarding page and add it to your content settings to use this feature. You add a forward-to-a-friend link to your page  by highlighting the link text and selecting **Link** on the text toolbar, and then using the [assist-edit](dynamic-email-content.md#assist-edit) feature to select the subscription center URL from the content settings.
- **View as a web page**: This link opens the marketing email message in a web browser. Some recipients will find this useful if their standard email client is having trouble rendering the message. You add this link to your page by highlighting the link text, selecting **Link** on the text toolbar, and then using the [assist-edit](dynamic-email-content.md#assist-edit) feature to select the view-as-webpage URL from the message object.

For more information about assist edit, content settings, and the message object, see [Add dynamic content to email messages](dynamic-email-content.md).

## Add dynamic content

Dynamic content is content that gets resolved just before a message is sent to a specific individual. You'll typically use dynamic content to merge information from the recipient's contact record (such as first and last name), to place special links, and to place information and links from the content settings. If you're comfortable working in code, you can also create custom logic that includes conditional statements, while loops, and more. You can use dynamic content in your message body and in the message header fields (subject, from address, and from name).

For complete details about these and other dynamic-content features, see [Add dynamic content to email messages](dynamic-email-content.md)

<a name="text-only"></a>

## Inspect and edit the text-only version of your message

The HTML mail standard allows for messages to include both an HTML version and a plain-text version of your content. The purpose of the plain-text version is to allow your message to be legible when shown by email clients that don't support HTML (or which have HTML turned off). Mail clients will only show one version to users, and unless you're dealing with a very special market, it will almost always be the HTML version. It's a bit like the system of providing alt-text for images.

So why bother with the plain-text version? To improve deliverability. One of the red flags that anti-spam systems look for is an email message that includes HTML content but no plain-text content (or plain-text content that doesn't match the HTML content). To help ensure that your marketing email messages don't get flagged as spam, Dynamics 365 generates a plain-text version of your HTML design and includes it when it sends the message. Usually you won't have to worry about the plain-text version, but you can still inspect and optimize it if you like.

Start by designing the HTML version of your message. When you're almost done, go to the **Summary** tab of your message, where you'll see various settings and metadata for the message. Scroll down to the **Plain Text** section to see the text that was auto-generated based on your HTML content.

- To fine-tune the text version, clear the **Automatically generate** check box to unlock the text field, and then edit the text as needed. From now on, though, your text version will no longer be linked to the HTML version and won't be updated to match any changes you make to the HTML.
- To go back to tracking the HTML version, reselect the **Automatically generate** check box. This will remove any customizations that you've made to the plain text and update it to match the current HTML design on an ongoing basis.

### See also

[Email marketing overview](prepare-marketing-emails.md)
[Create a marketing email](create-marketing-email.md)  
[Design your digital content](design-digital-content.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)
[Design elements reference](content-blocks-reference.md)  
[Work with email, page, and form templates](email-templates.md)  
[Upload and use images and files](upload-images-files.md)  

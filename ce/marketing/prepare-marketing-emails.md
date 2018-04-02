---
title: "Design, preview, check, and send marketing emails (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to design and deliver marketing email messages in Dynamics 365 for Marketing"
keywords: "email; marketing email; dynamic content; go live; validation; preview; Litmus"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 021f45f6-ed70-4979-a227-0631540b2516
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Prepare marketing email messages

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

<div class="embeddedvideo"><iframe src="https://www.microsoft.com/en-us/videoplayer/embed/17c3476e-9383-413b-98ec-0b1ac6659824" frameborder="0" allowfullscreen=""></iframe></div>

The process for creating marketing emails in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] begins with understanding what makes them such a powerful tool for your marketing campaigns. After you create a good design aimed at a specific segment of your audience, you preview it and check for errors before going live. You can fine-tune the reach and effectiveness of your message through advanced operations like merging database values, adding dynamic content, and introduce programming logic.

## How marketing email works in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]

Marketing email in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] works quite differently from the person-to-person messaging that you already use. Here are a few of the most important differences:

- **Marketing email messages target entire market segments, but each message is individual**  
    Your marketing email messages aren't just standard messages with giant To or Bcc fields. Long lists of recipients are difficult to manage and analyze, and messages such as these will typically get swept up by spam filters and never be delivered to your contacts. In [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], you'll target a single marketing email message design to an entire marketing segment, but each individual message is personalized for each recipient and delivered, one at a time, from your organization to the recipient.
- **Mail-merge features enable personalized and dynamic content**  
    You can design your messages to include information that gets personalized for each recipient. For example, each delivered message might include the recipient's name or other content that varies based on the recipient's gender, location, preferred-customer status, or other information from your contact database. Personalized features such as these can greatly improve your open and response rates.
- **Marketing email messages are hosted on your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] server, so you must "go live" rather than just send messages.**  
    A live message is enabled for use by your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] server, ready to be personalized and sent to individual recipients any number of times. You can think of a live marketing email message as a master document that stays on your server and typically includes active logic, ready to generate and send individual email messages when called from a customer journey (more on this later).
- **Required content and automated error-checking help improve deliverability and ensure compliance**  
    When you try to go live with a message, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] checks for common technical errors to make sure it includes all required content. Required content includes features that will help maintain your organization's email reputation and features that are typically required by email-marketing regulations in most countries and regions (such as the CAN-SPAM regulations in the United States). Required features include a subscription center link (so contacts can manage their email subscriptions with you), your organization's physical address, a message subject, and a valid return address.
- **Set up a customer journey to deliver messages to a target segment**  
    When your email message is live, it's ready for use in a *customer journey*. The customer journey establishes a target segment (which is a strategically selected list of contacts) and includes logic for working with that segment. For example, the customer journey might target a segment of contacts who live in New York City, and begins by sending an email message announcing an event in the city. The customer journey then applies a "trigger" that separates contacts who sign up for the event from those who don't; customers who sign up receive an automatic thank-you email, while those who haven't signed up within a week will get a reminder email. This customer journey requires three email messages (invite, thank you, and reminder), all of which must be live on your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] server before you start running the customer journey.
- **You can use a single marketing email message in several marketing contexts**  
    In addition to the ability to merge recipient information and other dynamic content, each marketing email message can also adapt to various marketing contexts defined by the content settings assigned to each customer journey where it's used. Examples of context include supporting page links (such as subscription center and forward pages), your postal address, social-media links, and more. With this feature, you can use a single live email message in several different customer journeys or campaigns.
- **View and analyze message results**  
    [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] keeps track of what happens to the marketing message it sends, and records when each contact opens, clicks, or forwards the message. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] tracks when messages are opened by including a unique [web beacon](https://en.wikipedia.org/wiki/Web_beacon) in each message (recipients must load images for this to work). For each link included in your original message design, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] creates a redirect link that's unique for each recipient, so all clicks get routed through [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], which logs the message and contact IDs and forwards the contact to the correct original URL. It tracks when messages are forwarded by a contact who uses the forward-to-a-friend form (but not when contacts simply forward a message by using their standard email client). You can review results and analytics for these and other details grouped by customer journey, email message, email template, and more.

## Process overview: How to create and go live with a marketing email

Below is an overview of the general process for creating and sending a marketing email. Complete details are provided later in this topic and in related topics.

1. Go to **Marketing Execution** &gt; **Marketing emails** to open the marketing email list view.

1. Select **New** to create a new message.

1. Choose a template, which establishes the basic format of your message.

1. Design your message by using the drag-and-drop designer or HTML editor.

1. Add a compelling **Subject** for your message.

1. Preview your message by using the **Preview** tab and by sending test messages.

1. Save your work as often as you want. The message remains in draft status until you go live with it.

1. Run an error check on your message. This makes sure you've included all the required elements and haven't introduced any invalid code. If errors are found, you'll see error messages with advice about how to fix them. Fix the errors as suggested, and continue to recheck until the message passes the error check.

1. Select **Go Live**. A final error check is done automatically as part of this process, so you won't be able to go live with a message unless it passes the check.

1. The message is now live and ready on your server, but it hasn't been addressed or sent yet; to do that, add it to a customer journey. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)

## Establish your basic layout by choosing the right template

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] includes a wide variety of templates, each of which includes both structural and style elements. Styled templates include color schemes and sample images, while structural templates include just a skeleton that establishes the basic structure and column layout. Though you can always change the content and styles, the column layout is semi-permanently established by the template you choose. To change the column layout, you must either create a new message and base it on the appropriate template, or edit the code directly by using the HTML editor.

When you create a new message from a template, the template content is copied into your new message. The message and template aren't linked, so when you edit the message, the template won't change; likewise, any future changes that you make to a template won't affect any existing messages that were created by using it.

You can also create your own custom templates, which can help both you and others in your organization to create new messages more quickly in the future. Design your templates so that they reflect your organization's graphical identity and fit closely with the types of campaigns you run most regularly. You can save any existing message as a template, or work directly in the templates area to design new templates based on existing ones. When setting up a template, you can add various types of metadata (such as purpose, style, market type, and optimized for) which make each template easier to identify and easier to find by using filters.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Work with email templates](email-templates.md)

## Design your content

After choosing a template, you'll be in the email content designer, which resembles the other digital content designers provided in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Work with it as follows:

- Use the **Design** &gt; **Designer** tab graphical tool to design your content by using drag-and-drop, point-and-click operations. Add new elements to your design by dragging blocks from the **Design** &gt; **Designer** &gt; **Toolbox** tab to the canvas. Choose a block that already exists in your design, and then open the **Design** &gt; **Designer** &gt; **Properties** tab to configure it and style it. To style the overall message with basic fonts, colors, and background, open the **Style** tab.

- When you select a content block on the canvas, you'll usually see a formatting toolbar just above the block. The controls offered by the toolbar vary depending on which type of block you've selected. Most toolbars provide buttons to move, copy, or delete the selected block, in addition to specialized buttons that vary by block type.

- When a text block is selected, you'll get a full formatting toolbar that you can use to apply basic text formatting like you would in [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-ms-word-short](../includes/pn-ms-word-short.md)]. It also includes an **Assist Edit** button **&lt;/&gt;**, which you can use to add dynamic content such as a mail-merge field that displays the recipient's name. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use assist-edit to place standard dynamic content](#use-assist-edit-to-place-standard-dynamic-content)

- Use the **Designer** &gt; **HTML** tab to edit the raw HTML directly. You might use this to paste in an existing HTML design, or to fine-tune the code in ways that aren't supported by the graphical editor (such as custom attributes or logic). The HTML editor has two subtabs: **HTML Source** (for editing the design, including logical expressions and dynamic content) and **HTML Output** (which resolves all dynamic content to provide static HTML that you can use in other applications).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design your digital content](design-digital-content.md)

## Add standard and specialized links to your message

Marketing messages are delivered as HTML and therefore support hyperlinks. Some types of links provide access to special features that are hosted by [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], whereas others can simply be standard links to content anywhere on the web. A subscription center link is required before any message can pass the error check and go live, but other links are optional, so you can use them only as needed. The following list describes the types of links that are available. You'll use the assist-edit feature to add most types of dynamic links as text in a text block (see the next sections for details about how to work with this tool), while other types of links are added by using a dedicated block type (such as an event block). [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add dynamic content](#add-dynamic-content)

- **Standard links**: You can add standard links to any text content by highlighting the link text and selecting **Link** on the text toolbar. You can also add link URLs to many other types of standard blocks, including images and buttons. When your message goes live, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] replaces each link with a unique redirect URL that targets your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] server and identifies the message recipient, message ID, and the destination you specified for the link. When a contact clicks a link, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] logs the click and then forwards the contact directly to the URL you specified.
- **Event, survey, or landing page**: These links go to an event portal, survey, or landing page. You can add them as text links in a text block, or as colorful call-to-action buttons. To create a button, drag an event, survey, or landing-page block to your email design and then configure which item the block should link to. To create a text link, select some text in a text block and then use the assist-edit feature.
- **Subscription center (required)**: All marketing email messages must include a link to a subscription center. A subscription center includes mailing lists available from your organization, including an option for contacts to opt out of all marketing emails. Contacts might also be able to update their contact details here. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] includes a standard subscription center, which you can edit to contain your subscription lists and to reflect your graphical identity (you can also create additional pages to support multiple subscription options, languages, or brands). You'll add a subscription center link to your page by using the assist-edit feature, which places code that creates a link to the subscription center identified in the content settings.
- **Forward to a friend**: This type of link opens a form that contacts can use to forward a marketing email to their own friends or colleagues by entering recipients' email addresses. It's a good idea to include this type of service for your contacts because messages forwarded by using the forward form are counted correctly in your email results and analytics (messages forwarded by using a contact's local email client forward feature won't be registered in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and all message opens and clicks performed by the recipients who were forwarded the message will be credited to the original recipient). A forward-to-a-friend page ID can be included in each set of content settings, but none is provided out of the box, so you must create a forwarding page and add it to your content settings to use this feature. You add a forward-to-a-friend link to your page by using the dynamic-content feature, which creates the link based on the page identified in the content settings.
- **View as a web page**: This link opens the marketing email message in a web browser. Some recipients will find this useful if their standard email client is having trouble rendering the message. You add this link to your page by using the assist-edit feature, which creates the link by using the message object itself.

<a name="dynamic-content"></a>

## Add dynamic content

Dynamic content is content that gets resolved just before a message is sent to a specific individual. You'll typically use dynamic content to merge information from the recipient's contact record (such as first and last name), to place special links, and to place information and links from the content settings. If you're comfortable working in code, you can also create custom logic that includes conditional statements, while loops, and more. You can use dynamic content in your message body and in the message header fields (subject, from address, and from name).

<a name="content-settings"></a>

### Use content settings to set up repositories of standard and required values for email messages

Content settings are sets of standard and required values that are available for use in marketing email messages. Each includes a subscription-center link, a forward-to-a-friend link, social-media links, your postal address, and other information that can be placed into the message as dynamic values by using the assist-edit feature.

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is delivered with a single default set of content settings, which is preconfigured to use the default subscription center (also included out of the box). You can customize this set as needed, and you can also create additional sets. You'll set up each customer journey to use a specific content-settings set, which means that all messages sent by that journey will use the same set. However, each journey can use a different set, which means that you can use an identical marketing-email design in two or more customer journeys, each specifying a different set of content settings. If you have more than one set of content settings, exactly one of them will be the default and will be applied automatically to each new customer journey that you create.

The values for content settings are first evaluated at send time, which means that you can edit a content-settings set at any time, and all pending and future email messages will automatically use the latest values.

To view, edit, create, or delete a content-settings set, go to **Templates** &gt; **Content Settings**. This takes you to a standard list page, where you can view, sort, search, and filter the list to find a specific record, and use commands on the command bar to add or remove a record. Select any item in the list to edit it.

Each content-settings record provides the settings described in the following table.

|**Setting**  |**Description**  |
|---------|---------|
|**Name**     |A name for the customer-settings set. This is the name shown when you're assigning content settings to a customer journey or email-message preview.|
|**Owner**     |The [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user who created the set.  |
|**Subscription Center**     |Specify an existing marketing page that is set up as a subscription center. Select the **&lt;/&gt;** button to choose from a list of available pages. All marketing email messages must include a valid subscription-center link taken from a content-settings set. |
|**Address Main**     |Enter the main part of your organization's postal address. All marketing email messages must include a valid main address taken from a content-settings set.|
|**Address Line 2**     |Enter supplemental postal address information (if needed).|
|**Default**     |Set to **Yes** to make the current content-settings set the default for all new customer journeys. There must always be exactly one default; if you change the default, the existing default will automatically be changed to **No**.|
|**Forward to a Friend**     |Specify an existing marketing page that is set up as a forward-to-a-friend page. Select the **&lt;/&gt;** button to choose from a list of available pages.   |
|**[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] URL**, **[!INCLUDE[tn-twitter](../includes/tn-twitter.md)] URL**, **[!INCLUDE[tn-facebook](../includes/tn-facebook.md)] URL**, and **[!INCLUDE[tn-youtube](../includes/tn-youtube.md)] URL**.      |For each of these social-media services, enter the landing page for your organization. |

### Use assist-edit to place standard dynamic content

Use standard dynamic content to position field values and links from recipient contact records, the message content settings, and other database values. The [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] **Assist Edit** button **&lt;/&gt;** helps you construct valid dynamic expressions. This button is provided on the text formatting toolbar whenever you select a text block in the graphical designer. The button is also provided for the subject field and for the from-address and from-name fields.

Start by positioning your cursor in the field where you want to insert the dynamic text, and then select the **Assist Edit** button **&lt;/&gt;** to open a drop-down list showing a selection of data sources appropriate for your current context, which can include some or all of the following:

- **Contact[context]**: Places a field value, such as a first name, from each recipient's contact record.
- **Content settings[context]**: Places a link or a field value from the content settings&mdash;a subscription center link, forwarding link, and the sender postal address are included here.
- **Marketing page**: Places a link to a specific marketing page, or a field value from the page.
- **Event**: Places a link to a specific event sign-up page, or a field value from the page.
- **Survey**: Places a link to a specific online survey (Voice of the Customer), or a field value from the survey.
- **Message[context]**:  Places functions that relate to the message itself; currently, an open-as-webpage link is the only value available from this source.


> [!NOTE]
> Entities shown by assist edit that include **[context]** in their name take values that can change for each recipient (such as the recipient's name). Entities that don't include **[context]** in their name must refer to a specific record ID, which doesn't change for each recipient. Note also that the **[context]** label isn't included in the code placed on the page when you're done (just the entity name).

After you've selected a source, the **Assist Edit** drop-down list is updated to show individual fields that are available from that source. Choose one of these to place the value or link. The result is an expression that uses a format such as *{{ SourceName.FieldName }}* or *{{ SourceName(RecordID).FieldName }}*, though more complex expressions can also be generated depending on the options you pick. Here are some examples:

- `{{ Contact.FirstName }}`  
Places the recipient's first name.
- `{{ ContentSettings.SubscriptionCenter }}`  
Places a link to the subscription center page identified in the active content settings.
- `{{ ContentSettings.ForwardToAFriend }}`  
Places a link to the forwarding page identified in the active content settings.
- `{{ Message.OpenAsWebPage }}`  
Places a link that opens the current message in a web browser.
- `{{ msevtmgt_event(123).msevtmgt_webinarurl }}`  
Places the web URL for the event identified by the specified event ID (123 in the example).
- `{{ msdyn_survey(321).msdyn_name }}`  
Places the name of the survey identified by the specified survey ID (321 in the example).
- `{{ Contact.Account.OwnerUser.PrimaryEmail }}`  
This is a useful expression for setting up the **From Email** address for a message. It resolves to the email address of the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user who owns the account associated with the mail recipient. This person is typically the account manager, who the recipient may know personally. Contacts are much more likely to open a message when it comes from somebody they know.
- `{{ Contact.Account.OwnerUser.FullName }}`  
This is similar to the previous example, but this time the expression resolves to the account manager's full name (useful for use in the **From Name** field).

### Advanced dynamic content

You can add advanced logical processing to your email design, which can make the content even more responsive to recipients, demographics, and context. This type of customization requires you to have a basic understanding of scripting and programming, and requires you to work directly with HTML code on the **HTML** tab of the content designer.

You must write your dynamic logic by using Handlebars syntax, which you can read about on the following webpages:

- [https://github.com/rexm/Handlebars.net](https://github.com/rexm/Handlebars.net)
- [https://handlebarsjs.com](https://handlebarsjs.com)

> [!NOTE]
> The assist-edit feature provided by the graphical editor creates Handlebars syntax and inserts it into the code automatically. You can see this when you open the message in the HTML editor. You can use either editor to add dynamic features supported by both, but the code editor is more flexible.

The following table provides a few examples of how you might use Handlebars to add custom, dynamic features to your marketing email messages.

| **Feature type** | **Description** | **Examples** |
|------------------|-----------------|--------------|
| Properties       | Inserts a database value|`{Contact.FirstName}}`<br />`{{ContentSettings.SenderAddress}}`|                      |
| If/Else          | Creates a conditional statement that decides at send time which content to include for each recipient. |`{{#if Contact.Deleted}}`<br />`Deleted`<br />`{{/if}}`<br /><br />`{{#if (eq Contact.Country 'Denmark')}}`<br />`Hej`<br />`{{/if}}`<br /><br />`{{#if (eq Contact.Country 'Denmark')}}`<br />`Hej`<br />`{{else if (eq Contact.Country 'UK')}}`<br />`Hi`<br />`{{/if}}`<br /><br />`{{#if (eq Contact.Country Contact.DeliveryCountry)}}`<br />`Delivered to you`<br />`{{/if}}`<br /><br />`{{#if (gt Contact.Age 18)}}`<br />`Apply now`<br />`{{/if}}`<br /><br />`{{#if (lte Contact.Age 70)}}`<br />`Apply now`<br />`{{/if}}`|
| For each         | Creates a for-each loop | `{{#each Contact.Addresses}}`<br />`{{this.StreetName}}`<br />`{{/each}}` |
|Relationships    | Finds database field values from a related record. | `{{Contact.Phone.PrimaryPhone}}`<br />`{{Contact.SalesPerson.Address.StreetName}}` |
| Custom entities  | Finds a value from a specific record, identified by an ID value. | `{{LandingPage(123).Url}}` |

## Inspect and edit the text-only version of your message

The HTML mail standard allows for messages to include both an HTML version and a plain-text version of your content. The purpose of the plaint-text version is to allow your message to be legible when shown by email clients that don't support HTML (or which have HTML turned off). Mail clients will only show one version to users, and unless you're dealing with a very special market, it will almost always be the HTML version. It's a bit like the system of providing alt-text for images.

So why bother with the plain-text version? To improve deliverability. One of the red flags that anti-spam systems look for is an email message that includes HTML content but no plain-text content (or plain-text content that doesn't match the HTML content). To help ensure that your marketing email messages don't get flagged as spam, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] generates a plain-text version of your HTML design and includes it when it sends the message. Usually you won't have to worry about the plain-text version, but you can still inspect and optimize it if you like.

Start by designing the HTML version of your message. When you're almost done, go to the **Summary** tab of your message, where you'll see various settings and metadata for the message. Scroll down to the **Plain Text** section to see the text that was auto-generated based on your HTML content.

- To fine-tune the text version, clear the **Automatically generate** check box to unlock the text field, and then edit the text as needed. From now on, though, your text version will no longer be linked to the HTML version and won't be updated to match any changes you make to the HTML.
- To go back to tracking the HTML version, reselect the **Automatically generate** check box. This will remove any customizations that you've made to the plain text and update it to match the current HTML design on an ongoing basis.

## Set advanced header options

In addition to the message description and plain-text version, the **Summary** tab also offers **Advanced Header** settings. Usually you shouldn't edit these, but they can be useful in some scenarios.

> [!IMPORTANT]
> When you create a new email, the **Advanced Header** settings are initially blank, but after you've made the standard settings for the **From** contact and saved the message at least once, the correct values are added here automatically. If you edit these values before saving (or after), correct default values will no longer be offered. You should only edit these values if you're sure you need to.

The following **Advanced Header** settings are available:

* **Email from name**: This is the name shown to recipients as the person who sent the email. By default, this is the name of the **From** contact chosen at the top of the form. You can edit this to use a static value, or choose the assist-edit button to define an alternative dynamic value.
* **Email from address**: This is the email address shown to recipients as the address of the person who sent the email. By default, this is the address of the **From** contact chosen at the top of the form. You can edit this to use a static value, or choose the assist-edit button to define an alternative dynamic value.
* **To**: This should almost always be set to **{{ contact.emailaddress1 }}**, which sends the message to each contact included in the customer journey that sends the email. You might change this to use a different email address field (such as emailaddress2), or enter a dynamic expression that chooses the best of several available email fields.
* **Reply-to email**: This should usually be blank, which means that replies to the message will be sent to the address of the **From** contact (or the **Email from address**, if it's different). If you set a value here, replies to your message will be sent to this address rather than the displayed from address. You can edit this to use a static value, or choose the assist-edit button to define an alternative dynamic value.


## Check your work by using previews and test sends

Your marketing email messages will probably be seen by many potential customers, so you'll want to make sure they look just right when opened, regardless of which combination of device and email software each recipient is using. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides several tools to help you test and evaluate your design before you use it in an email campaign.

### Send a test message

Select **Test Send** to send your current design to any recipient or group of recipients. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] then asks you to specify test recipients by entering one or more email addresses or by choosing a marketing list. If you choose a list, be careful not to send the test to a large audience you didn't intend to send the message to.

### Preview your message in the designer

The content designer provides two types of previews when you're designing a marketing email message:

- **Standard preview**: Go to the **Designer** &gt; **Preview** &gt; **Basic Preview** tab to see the standard designer preview and choose between various form factors, contacts, and content settings.
- **Inbox preview**: Go to the **Designer** &gt; **Preview** &gt; **Inbox Preview** tab to see real-world inbox previews that show your design exactly as it will appear in a wide variety of target email clients and platforms.

See the following sections for details about each of these types of previews.

### Use the basic preview feature

Go to the **Designer** &gt; **Preview** &gt; **Basic Preview** tab to see an in-browser preview that simulates how your message will typically be rendered on various form factors (desktop, tablet, or phone) and orientations (portrait or landscape).

Use the form-factor icons on the left side of the **Designer** &gt; **Preview** &gt; **Basic Preview** tab to switch between the available form factors for the preview.

Use the following drop-down lists on the right side of the **Designer** &gt; **Preview** &gt; **Basic Preview** tab (under the **Properties** heading) to test the effects of your dynamic content and logic:

- **Contact**: Choose a representative contact record to supply field values. Field values from your selected contact, and other dynamic content that reacts to these values, will be shown in your preview.
- **Content Settings**: The content settings establish a marketing context for your message, and values stored here might affect your message content. The content settings also include information about your organization, including its postal address and the ID of a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] subscription center page. In a basic setup, you might have just one set of content settings for your entire organization. But in a more advanced configuration, you might reuse a single marketing email message in several different contexts (such as for different products or different events); in this case, the content settings can be different for each customer journey where you use the message. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use content settings to set up repositories of standard and required values for email messages](#use-content-settings-to-set-up-repositories-of-standard-and-required-values-for-email-messages).

<a name="inbox-preview"></a>

### Use the advanced inbox preview feature

Go to the **Designer** &gt; **Preview** &gt; **Inbox Preview** tab to see real-world inbox previews that show your design exactly as it will appear in a wide variety of target email clients and platforms. This feature renders your message by using native code from each of the listed target platforms, and then delivers your preview as an image file showing the precise results. As with the simple preview, you can use the **Designer** &gt; **Preview** &gt; **Inbox Preview** &gt; **Properties** tab to choose a **Contact** record and **Resource Set** from which to draw dynamic values (see also the previous section).

The inbox preview is provided by a [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] partner called Litmus Software, Inc. ([litmus.com](https://litmus.com/)). Your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] license includes a limited number of inbox previews each month (typically 100), and this quota is shared by your entire organization. After your organization has used all the available previews for the month, each user must set up their own Litmus account if they want to create additional previews. Personal Litmus quotas apply to individual users, not to the entire organization. When you've used all your free previews, you'll be given the option to sign in to Litmus directly from the **Inbox Preview** tab in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. After you're signed in, the integration is seamless.

The **Inbox Preview** tab displays a grid of icons, each labeled with the name of a different destination platform or email client. Initially, each preview is dimmed and shows a key (locked) icon, which means that you haven't yet generated that preview by using your current design and settings. Select one of these icons to generate that preview and unlock its icon. Each time you unlock a preview, you'll use one preview from either your organization's or your personal quota. The unlocked preview remains available for viewing until you change the design or the **Properties** (dynamic text) settings, at which time all existing previews will no longer be valid and will be shown as locked again.

> [!NOTE]
> Litmus must be enabled for your site before you can use it. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Default marketing settings](marketing-settings.md#marketing-configuration)

## Required elements: How to pass the error check

Before you can send your message, it must pass an error check. You can run an error check at any time by selecting **Check for Errors** in the designer. An error check is also run automatically each time you select **Go Live**.

All messages must include the following:

- Subscription center link, taken from the content settings as ContentSettings.SubscriptionCenter.
- Sender's physical address, taken from the content settings as ContentSettings.SenderAddress.
- A valid subject or a dynamic expression that resolves to valid text.
- A valid From name and address, or a dynamic expression that resolves to a valid name and address.
- An HTML body (your message content).
- A plain-text version of the message. This version must exist and must also include a subscription center link and the sender's physical address (this usually gets generated automatically, but you should review it).

The following are also confirmed by the check:

- All dynamic expressions and HTML code must compile and generate valid values.
- All referenced images must exist in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].
- The To field must be an expression (not static) that results in a valid email address; this is normally handled automatically by the customer journey that sends the mail, but some advanced scenarios allow for customization here.

## Go live and set up a customer journey to deliver your message

While you prepare a message, it stays in a draft state, which means that it's inactive and can't be sent. To send it, you must first publish it (which activates its dynamic content and moves it to the bulk messaging server), and then add it to a customer journey (which, at minimum, establishes a target segment and then sends the message to all the contacts in that segment).

To publish a message, open it and select **Go Live**. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] will run a final validation check, as described in the previous section, and&mdash;if it passes&mdash;publish the message. If errors are returned, read the error messages, address the issues, and try again until the message is successfully published.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)

### See also

[Create a marketing email](create-marketing-email.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Design your digital content](design-digital-content.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)
[Content blocks reference](content-blocks-reference.md)  
[Work with email templates](email-templates.md)  
[Upload and use images and files](upload-images-files.md)
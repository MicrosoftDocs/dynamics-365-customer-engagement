---
title: "Add dynamic content to marketing emails (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to add field values, set up content settings information, conditional statements, and while loops to your email designs in Dynamics 365 for Marketing"
keywords: "email; marketing email; dynamic content; content settings"
ms.date: 08/23/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5134e656-31ae-4984-8045-fcd76b98719a
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

# Add dynamic content to email messages

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Dynamic content gets resolved just before a message is sent to a specific individual. You'll typically use dynamic content to merge information from the recipient's contact record (such as first and last name), to place special links, and to place information and links from the content settings. If you're comfortable working in code, you can also create custom logic that includes conditional statements, for-each loops, and more. You can use dynamic content anywhere in your message body and can also use a few types of dynamic values in the message header fields (subject, from address, and from name).

<a name="content-settings"></a>

## Use content settings to set up repositories of standard and required values for email messages

Content settings are sets of standard and required values that are available for use in marketing email messages. Each includes a subscription-center link, a forward-to-a-friend link, social-media links, your postal address, and other information that can be placed into the message as dynamic values by using the assist-edit feature.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] is delivered with a single default set of content settings, which is preconfigured to use the default subscription center (also included out of the box). You can customize this set as needed, and you can also create additional sets. You'll set up each customer journey to use a specific content-settings set, which means that all messages sent by that journey will use the same set. However, each journey can use a different set, which means that you can use an identical marketing-email design in two or more customer journeys, each specifying a different set of content settings. If you have more than one set of content settings, exactly one of them will be the default and will be applied automatically to each new customer journey that you create.

The values for content settings are first evaluated at send time, which means that you can edit a content-settings set at any time, and all pending and future email messages will automatically use the latest values.

Each content-settings record that you use must be available to the external marketing services, which manage email assembly and delivery. Therefore, you must publish your content-settings records by choosing **Go Live** whenever you create a new one.

To view, edit, or create a content-settings set:

1. Go to **Marketing** > **Templates**  >  **Content Settings**.

1. A standard list page opens where you can view, sort, search, and filter the list to find a specific record and use buttons on the command bar to add or remove a record. Select a record to open it for editing or select **New** on the command bar to create a new one.

1. The **Content Settings** form opens. If you are editing a record that is already live, you must choose **Edit** in the command bar before you can edit it. If you are creating a new one, you can just start filling in the fields.  

    ![The content-settings form](media/content-settings-form.png "The content-settings form")

1. Make the following settings, as needed:

    - **Name**: Enter a name for the customer-settings set. This is the name shown when you're assigning content settings to a customer journey or email-message preview.
    - **Owner**: Shows the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] user who created the set.
    - **Address main**: Enter the main part of your organization's postal address. All marketing email messages must include a valid main address taken from a content-settings set.
    - **Address line 2**: Enter supplemental postal address information (if needed).
    - **Default**: Set to **Yes** to make the current content-settings set the default for all new customer journeys. There must always be exactly one default; if you change the default, the existing default will automatically be changed to **No**.
    - **LinkedIn URL**,  **Twitter URL**,  **Facebook URL**, and  **YouTube URL**: For each of these social-media services, enter the URL for the landing page for your organization.  
    - **Subscription center**: Specify an existing marketing page that is set up as a subscription center. Select the  **&lt;/&gt;**  button to use [assist-edit](#assist-edit) to choose from a list of available pages. You could instead enter a custom URL or expression that links to an external subscription center here (see the notes after this list). All marketing email messages must include a valid subscription-center link taken from a content-settings set.
    - **Forward to a friend**: Specify an existing marketing page that is set up as a forward-to-a-friend page. Select the  **&lt;/&gt;**  button to use [assist-edit](#assist-edit) to choose from a list of available pages. You could instead enter a custom URL or expression that links to an external forwarding page.

    > [!NOTE]
    > When you choose a [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] marketing page for the subscription center or forwarding page, the resulting expression should resemble the following: `{{msdyncrm_marketingpage(a2d3c828-74af-e811-a95b-000d3a3655ec).msdyncrm_full_page_url}}`, where the value in parenthesis is the [record ID](#record-id) of the marketing page, and `msdyncrm_full_page_url` places the URL of that page.

    > [!IMPORTANT]
    > It's possible to use an external subscription center rather than one created and hosted by [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] by entering its URL in the **Subscription center** field. You can use dynamic expressions in your URL (for example, to add the recipient's email address as a URL parameter value), but the [assist-edit](#assist-edit) button won't help you do that while working in this field, so you must type the expression manually (or you could use assist-edit to construct the expression, for example, in a text element and then copy it here). If you choose to use an external subscription center, then it is your organization's responsibility to ensure that it complies with all regulations in the countries/regions of all marketing email recipients. Custom development will most likely be required to integrate your external system with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

1. Select **Save** in the bottom-right corner of the window to save your settings.

1. If you are editing a content-settings record that was already live, then the record is republished automatically when you save it. If you are creating a new record, then select **Go live** on the command bar to publish it to the marketing services so you can start using it.

<a name="assist-edit"></a>

## Use assist-edit to place dynamic field values

The **Assist Edit**  button  **&lt;/&gt;**  helps you construct valid dynamic expressions to position field values from recipient contact records, the message content settings, and other database values. This button is provided on the text formatting toolbar whenever you select a text element in the graphical designer. The button is also provided for some settings fields, such as the subject, from-address, and from-name fields.

Start by positioning your cursor in the field where you want to insert the dynamic text, and then select the  **Assist Edit**  button  **&lt;/&gt;**  to open a drop-down list showing a selection of data sources appropriate for your current context, which can include some or all of the following:

- **Contact[context]**: Places a field value, such as a first name, from each recipient's contact record.
- **Content settings[context]**: Places a field value from the content settings—a subscription center URL, forwarding URL, and the sender postal address are included here.
- **Message[context]**: Places values that relate to the message itself; currently, this includes the open-as-webpage URL and the various dynamic values used in [double opt-in emails](double-opt-in.md).
- **Account**: Places a value from a specific account record.
- **Contact**: Places a value from a specific contact record (not the recipient's record).
- **Event**: Places a link to a specific event sign-up page, or a field value from the page.
- **Lead**: Places a value from a specific lead record.
- **Marketing list**: Places a value from a specific marketing list.
- **Marketing list member**: Places a value from a specific marketing list member.
- **Marketing page**: Places a link to a specific marketing page, or a field value from the page.
- **Survey**: Places a link to a specific online survey (Voice of the Customer), or a field value from the survey.

> [!NOTE]
> Entities shown by assist edit that include **[context]** in their name take values that can change for each recipient (such as the recipient's name). Entities that don't include **[context]** in their name must refer to a specific record ID, which doesn't change for each recipient. Note also that the **[context]** label isn't included in the code placed on the page when you're done.

> [!NOTE]
> The entities included in the assist-edit menu are those that you are currently syncing with the customer-insights service, which means that you might see more entities than those mentioned in the previous list. If you need to show information from an entity that isn't listed, then ask your admin to add that entity to the customer-insights service. If you are an admin, then see [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync) for instructions.

After you've selected a source, the  **Assist Edit**  drop-down list is updated to show individual fields that are available from that source. Choose one of these to place the value or link. The result is an expression that uses a format such as `{{EntityName.FieldName}}` or `{{EntityName(RecordID).FieldName}}`, though more complex expressions can also be generated depending on the options you pick. Here are some examples:

-  `{{contact.firstname}}`  
Places the recipient's first name.
- `{{msdyncrm_marketingpage(a2d3c828-74af-e811-a95b-000d3a3655ec).msdyncrm_full_page_url}}`  
Places the URL for the marketing page identified by the [record ID](#record-id) in parentheses.
- `{{msdyncrm_contentsettings.msdyncrm_subscriptioncenter}}`  
Places the URL for the subscription center page identified in the content settings configured for the customer journey that sends the message.
- `{{msdyncrm_contentsettings.msdyncrm_forwardtoafriend}}`  
Places the URL to the forwarding page identified in the content settings configured for the customer journey that sends the message.
- `{{Message.ViewAsWebpageURL}}`  
Places the URL for opening the current message in a web browser.
- `{{msevtmgt_event(8a519395-856c-4e22-b560-650ce6d6a79d).msevtmgt_webinarurl}}`  
Places the webinar URL for the event identified by the [record ID](#record-id) in parentheses.
- `{{msdyn_survey(39128da2-c968-4627-9595-f030b6571be4).msdyn_name}}`  
Places the name of the survey identified by the specified survey ID (in parentheses).

<a name="record-id"></a>

## Find record IDs

Non-contextual field expressions (which use the form  `{{EntityName(RecordID).FieldName}}`) require a record ID to identify the specific record the value must come from. To find the ID for any record:

1. Open the record you want to reference
2. Look at the URL shown in your browser's address bar, which should show a URL such as:  
`https://<MyOrg>.crm.dynamics.com/main.aspx?appid=c8cba597-4754-e811-a859-000d3a1be1a3&pagetype=entityrecord&etn=msevtmgt_event&id=5acc43d5-356e-e811-a960-000d3a1cae35`
3. Find the part of the URL that starts with `&id=`, which is followed by the ID number of your current record. Copy that number (the value only) and use it in your expression.

## Dynamic values in To, From-name, From-address, and Reply-to fields

On the **Summary** tab of the **Marketing Email** form, you can make various non-content-related settings for your message in the **Advanced Header** section. This includes values and expressions for establishing the to, from-name, from-address, and reply-to values the message will use.

![Advanced header settings for email messages](media/email-advanced-header-settings.png "Advanced header settings for email messages")

Though these settings provide assist-edit buttons, you must only place static values, or values from the **Contact[context]** entity, such as `{{contact.emailaddress1}}` (which is the default for the **To** address). These settings don't currently support any other entities or lookup-field values.

> [!TIP]
> You can include conditional statements in the **Advanced Header** fields—for example, to use `contact.emailaddress2` if `contact.emailaddress1` is empty. But you can still only refer to the contact entity in your conditional expressions and displayed fields.

## Advanced dynamic content

> [!NOTE]
> The advanced dynamic-content features described in this section are scheduled to be rolled out to customer organizations gradually throughout the last half of 2018. To see if they are available to your organization, create a message and paste in the following conditional example:
> 
> `{{#if (eq contact.contact_account_parentcustomerid.name 'abc')}} Hello. {{else if (eq '123' '123')}} Advanced dynamic content is enabled. {{/if}}`
> 
> Then open the **Preview** tab. If the preview shows "Advanced dynamic content is enabled," then you have the feature. If instead you see the entire line of code, plus error messages like "We couldn't resolve the message template" or "HTML property not found", then you don't have it yet.  If you don't have the feature available, and require it urgently, then please contact [!INCLUDE[pn-microsoft-support](../includes/pn-microsoft-support.md)] for assistance.

You can add advanced logical processing to your email designs, which can make the content even more responsive to recipients, demographics, and context. This type of customization requires you to have a basic understanding of scripting and programming. You can enter the code while working on either the **Designer** or **HTML** tab of the content designer.

As you've seen in previous examples, dynamic content is surrounded by double braces ( `{{` and `}}` ). This includes both standard field values that you add using the assist-edit feature, and the more advanced programming constructs described in this section.

> [!TIP]
> If you want to display double braces in a message, rather than use them to denote the start or end of a code block, then prepend (escape) the first brace with a backslash, such as `\{{` or `\}}`. The slashes won't appear in your final, rendered message, but the double braces will.

### Fetch custom values from fields and lookup fields

As we've seen, you can use the assist-edit feature to insert both context-sensitive and specific-record values from your database in your email messages—the result is an expression that uses a format such as `{{EntityName.FieldName}}` or `{{EntityName(RecordID).FieldName}}`, as illustrated in the examples shown in [Use assist-edit to place dynamic field values](#assist-edit).

> [!TIP]
> If you require the types of data that are supported by assist-edit, then it's usually best to use the assist-edit feature to place the code. This will ensure that the entity and field names match those used in the database and will help you avoid misspellings.

You can place nearly any database value into your messages using the same types of syntax created when using assist-edit, but you'll need to find the correct entity, relationship, and field names (for example, by using the tools for [customizing entities, relationships and fields](../customize/customize-entities-relationships-fields.md)).

> [!NOTE]
> You can only use data from entities that are synced with the customer-insights service (and therefore also listed in the assist-edit menu). If you need to show information from an entity that isn't yet synced, then talk to your admin. If you are an admin, then see [Choose entities to sync with the customer-insights services](marketing-settings.md#dci-sync) for instructions.

In addition, you can also construct expressions that fetch values from lookup fields (which link to related records) by adding an extra "hop" in your expression, where each hop (also known as an _access operator_) is indicated by a period (.), such as:

- `{{EntityName.RelationshipName.FieldName}}`
- `{{EntityName(RecordID).RelationshipName.FieldName}}`

Here are a few useful examples for placing lookup field values:

- `{{contact.contact_account_parentcustomerid.name}}`  
This expression finds the name of the account for the company where a contact works.
- `{{contact.contact_account_msa_managingpartnerid.name}}`  
This expression finds the name of the managing partner for the account for the company where a contact works.

> [!IMPORTANT]
> You can use, at most, two hops (periods) in your field expressions.

### Conditional statements and comparisons

Conditional (if-then-else) statements display content depending on whether one or more conditional expressions resolve to true or false. They take the following form:

 ```Handlebars
{{#if (<operator> <value1> <value>)}}
      Content displayed when the expression is true
{{else if (<operator> <value1> <value>)}}
      Content displayed when the first expression is false and the second one is true
.
.
.
{{else}}
      Content displayed when all expressions are false
{{/if}}
```

Where:

- The conditional block must always open with `{{#if … }}`.
- Conditional expressions must be contained in parentheses.
- Conditional expressions start with an &lt;operator&gt;, which must be one of the values listed in the following table. It establishes how the first value is to be compared to the second value.
- &lt;value1&gt; and &lt;value2&gt; are values to be compared by the conditional expression, and each can be either dynamic or constant values. If either &lt;value1&gt; or &lt;value2&gt; is a constant string value (not a number or expression), then it must be surrounded with single quotes ('); for real numbers, use a period (.) as a decimal delineator.
- `{{else}}` and `{{else if … }}` clauses are optional.
- The conditional block must always close with `{{/if}}`.

The following table lists all the operators that you can use in your conditional expressions. Other operators are not currently available, nor can you use complex Boolean expressions (such as with AND or OR operators) in your conditional expressions.

| **[!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] syntax (case sensitive)** | **Operator** |
| --- | --- |
| eq | Equal to |
| ne | Not equal to |
| lt | Less than |
| gt | Greater than |
| lte | Less than or equal to |
| gte | Greater than or equal to |

For example, this conditional statement could be used to establish the language used in a message salutation based on the country of each message recipient:

 ```Handlebars
<p>{{#if (eq contact.address1_country 'Denmark')}}
     Hej
{{else if (eq contact.address1_country 'US')}}
     Hi
{{/if}} {{contact.firstname}}!</p>
```

> [!TIP]
> You can test for empty field values by using:  
> ```Handlebars
> {{#if (eq contact.lastname '')}}
> ```
> Where `''` is two single quotation marks, not a double quotation mark. This finds empty fields, but not null fields.

> [!TIP]
> Though you can't use complex Boolean expressions in your conditional expressions, you can implement similar functionality as follows:
> 
> Not supported:  
> ```Handlebars
> {{#if A and B}}<DisplayedContent>{{/if}
> ```
> Is equivalent to (supported):
> ```Handlebars
> {{#if A}}{{#if B}}<DisplayedContent>{{/if}}{{/if}}
> ```
> &nbsp;  
> Not supported:
> ```Handlebars
> {{#if A or B}}<DisplayedContent>{{/if}
> ```
> Is equivalent to (supported):
> ```Handlebars
> {{#if A}}<DisplayedContent>{{/if}} {{#if B}}<DisplayedContent>{{/if}}
> ```

### For-each loops

For-each loops let you step through a collection of records that are related to a specific current record—for example, to provide a list of all the recent transactions associated with a given contact.

For-each loops take the following form:

 ```Handlebars
{{#each Entity.RelationshipName }}
    ...
    {{this.RelatedField1}}
    ...
    {{this.RelatedField2}}
    ...
{{/each}}
``` 

Where:

- The loop block must always open with `{{#each … }}`.
- `Entity.RelationshipName` identifies the set of related records that the loop will iterate over.
- The loop starts with the first available related record, and repeats for each available related record until all related records have been listed. Note that the related records will be returned in an arbitrary and unpredictable order.
- `{{this.RelatedField<n>}}` identifies a field name from the related record. The "this" part of this expression refers to the related record being processed in the current loop iteration, and must be followed by a valid field name for the related entity. You can include any number of fields in each loop.
- The loop block must always close with `{{/each}}`.

For example, your database could include a list of products that a contact has ordered. You could list these in an email message using code such as:

```Handlebars
<p>You have purchased:</p>
<ul>
<!-- {{#each contact.contact_product_productid}} -->
<li>{{this.name}}</li>
<!-- {{/each}} -->
</ul>
``` 

In this example, the [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] system has been customized to include a [custom entity](../customize/create-edit-entities.md) called _product_, which is set up with a 1:N [relationship](../customize/create-edit-entity-relationships.md) between the _contact_ and _product_ entities on the _productid_ field. For the product entity to be available to your email messages, it must also be [synced](marketing-settings.md#dci-sync) with the customer-insights database (as usual).

### Mix your code with content in the editor

Often, programmers use multiple lines and indents to format their code during development. This makes the code easier to read and understand. The examples in this help topic likewise use techniques such as these to illustrate the structure of the code. However, when you enter your code into the designer, it's important that you compact the code and maintain your page layout—and that means removing all the extra lines and spaces. Here are some tips for how to enter your code in the designer:

- You can work on either the **HTML** or **Designer** tab.
- If are working on the **Designer** tab, avoid all extra spaces and carriage returns because these will create `&nbsp;`and `<p>` tags in your code, which will result in unwanted empty space in your rendered design. If you go to the **HTML** tab, you'll see all of these extra tags in your code.
- If you are working on the **HTML** tab, then all the code must either be contained within a set of start and end tags (such as `<p>` and `</p>`) or within an HTML comment (for code that is entirely separate from displayed text). Do not place code outside of comments or valid HTML tag pairs, as that will confuse the editor (especially if you switch between the **HTML** and **Design** tabs).
- If you are working on the **HTML** tab, then you can add extra spaces and carriage returns to your code, but these will probably be collapsed automatically into a single line if you or anyone else opens the message using the **Designer** tab.

For example, you could set up the salutation line of an email message by entering the following onto the **HTML** tab of the designer:

```Handlebars
<p>{{#if (eq contact.address1_country 'Denmark')}}Hej{{else if (eq contact.address1_country 'US')}}Hi{{/if}}{{contact.firstname}}!</p>
```

This example (also shown previously) shows how to use comments to enclose code that exists entirely outside of displayed content (also on the **HTML** tab):

```Handlebars
<p>You have purchased:</p>
<ul>
<!-- {{#each contact.contact_product_productid}} -->
<li>{{this.name}}</li>
<!-- {{/each}} -->
</ul>
```

### See also

[Design your digital content](design-digital-content.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)  
[Create automated campaigns with customer journeys](customer-journeys-create-automated-campaigns.md)

---
title: "Set up a subscription center in Dynamics 365 for Marketing | Microsoft Docs"
description: "How to create subscription lists and add them to a subscription center in Dynamics 365 for Marketing"
keywords: "tutorial; subscription center; static list; subscription list; marketing page; page"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
	- Dynamics 365 (online)
	- Dynamics 365 Version 9.x
ms.date: 11/07/2017
ms.service: crm-online
ms.topic: get-started-article
ms.assetid: 21159fd7-50cc-4879-884c-888bc0d6b457
ms.reviewer: renwe
---
# Set up subscription lists and subscription centers

A subscription center is a marketing page that known contacts can use to manage their communication preferences and contact details with your organization.

All marketing email messages that you create using [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] must include a link to a subscription center and will fail the error check if you try to go live with a message that lacks this link. There are two good reasons for requiring a subscription center link in all marketing email messages:

- **Legal requirements**: Many countries/regions have laws that require all marketing email messages to include an unsubscribe link.

- **Deliverability**: Spam filters and internet reputation monitors can identify marketing email messages and may remove those that don’t include an unsubscribe link.

All subscription centers include a “do not email” check box. When a contact chooses this option, the do-not-bulk-email flag gets set on his or her contact record and [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] will never send any marketing email messages to them. Optionally, your subscription center can present several additional subscription options, such as a list of available newsletters. By presenting several different mailing lists on your subscription center, you gain an opportunity to learn more about your contacts’ specific interests while also giving contacts more options beyond the legally required “do not bulk email” option.

Each subscription list exists as a static marketing list in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)], while “do not bulk email” is an explicit attribute of the contact entity. That means that “do not bulk email” overrules subscription list memberships, but also that list memberships will be reactivated if a contact later clears “do not bulk email”.

The only way a contact can access a subscription center is by clicking on a link sent to them in email. Email links are always personalized for the recipient, which means that [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] always knows which contact has requested the subscription center and therefore populates it with that contact’s current details and subscriptions. (Note that you can also add subscription lists to standard marketing pages, which enables inbound (previously unknown) contacts to sign up for one or more mailing lists at the same time as they register with your site.)

A default subscription center is provided with [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)], but it is very simple, including just a minimum of contact fields and the required “do not bulk email” check box. In this exercise, we’ll walkthrough the process of creating a subscription list and adding it to a subscription form. We’ll also point out how to choose a subscription center in content settings and how to assign content settings to a customer journey.

## Create a subscription list

Subscription lists are based on the standard (static) marketing lists feature of [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]. To create one:

1.  In [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)], open the app selector and choose the **Surveys** app module. ([!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] lists aren’t included in the current version of the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] work area, so one pace you can find them is in the Surveys app, which is included with [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] for [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].)

> ![How to open the surveys app](media/app-selector-surveys.png "How to open the surveys app")  

1.  The navigator for the Surveys app is a bit different from the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app; it’s horizontal and at the top of the screen. Use it to navigate to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Customers &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Lists**.

> ![How to open marketing lists in the surveys app](media/surveys-app-lists.png "How to open marketing lists in the surveys app")  

1.  You now see a list of existing marketing lists (if any). Choose **New** from the toolbar to create a new list.

2.  The **New [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] List** page opens.

> ![How to configure a list as a subscription list](media/subscription-list-example.png "How to configure a list as a subscription list")  
>
> Make the following settings (at minimum):

- **Name**: Enter a descriptive name

- **Subscription**: Set to **True**.

|                                                                                                                                                                                                                                                                                                                              |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** When you set **Subscription** to **True**, the **List Type** is automatically set to **Static** and **Targeted At** is automatically set to **Contact**. Both of these settings are consistent with the requirements of a subscription list, and they remain locked unless you change the **Subscription** setting. |

1.  Choose **Save** from the command bar to save your new subscription list.

## Add a subscription list to a subscription form

Now that you have a subscription list available, you can add it to a subscription form. The procedure is about the same as for adding other types of input fields to a form.

1.  If you are still in the **Surveys** app, use the app selector to go back to the **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)]** app.

2.  In the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app, go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Internet [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Forms**.

3.  You now see a list of forms. Choose **New** from the command bar to create a new one.

|                                                                                                                                                                                                                                                                                                                                                  |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** You could instead edit an existing form by choosing it from the list, but for this exercise we’ll describe how to create a new one. Note that if you edit an existing form, then your edits will affect all marketing pages that use that form because forms are imported by reference, not copied into the page like template content. |

1.  The **Select a Form Template** dialog opens.

> ![How to find a subscription center template](media/form-template-subcenter.png "How to find a subscription center template")  
>
> Do the following:

-   It’s important to select a template of the correct type (subsection center), so start by filtering the template list by choosing the **Type** tab and then choose **Subscription center** from the drop-down list here.

-   Choose a template (we’ll show the **1-Column Subscription Center** for this exercise) and then choose **Select**.

1.  Your selected template is now copied into your new form design.

> ![Edit the heading inserted by the form template](media/form-headings-from-template.png "Edit the heading inserted by the form template")  
>
> As you can see, the template has already provided the following:

-   A basic contact-information form that includes several typical fields

-   A **Do not email** check box (which is required for all subscription forms)

-   A **Submit** button (which is required for all forms)

-   Two headings with placeholder text surrounded with square brackets.

> Work directly on the canvas to select and each of the placeholder headings (including the brackets) and replace them with actual headings (for example, “Update your contact information” and “Newsletter subscriptions”).

|                                                                                                                                                                                                                                                                                                                                                                            |
|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** Many of the supplied templates for emails, pages, and forms employ this convention of using square brackets to mark instructional placeholder text. They also typically use pseudo Latin (“lorum ipsum”) text as a placeholder for body text, and sometimes example text for headlines, but these don’t use square brackets because the text isn’t instructional. |

1.  In the **Toolbox** tab, scroll down until you find the **Subscription Lists** heading. You should see the subscription list that you just made listed here, plus any others that were already in your system. Drag it from the **Toolbox** to the space under the “Newsletter subscriptions” heading.

> ![Add a subscription list to the form](media/from-add-subscription-list.png "Add a subscription list to the form")  

|                                                                                               |
|-----------------------------------------------------------------------------------------------|
| **TIP:** Only forms of type “subscription center” show subscription lists in the **Toolbox**. |

1.  Choose **Save** from the command bar to save your new form.

## Create a subscription center marketing page

Go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Internet [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Pages** and create a subscription center page using the same basic procedure that you used to create a landing page, but be sure to do the following:

1.  Make sure the page **Type** is **Subscription Center**. (Or choose a marketing page template where **Type** is **Subscription Center**).

2.  Include a **Form** block that references the subscription form you just made.

3.  Enter values for all other required fields (**Name** and **Partial URL**).

4.  Choose **Check for Errors** and address any issues reported.

5.  Choose **Go Live**.

For a detailed walkthrough of how to create a marketing page, see [Create a landing page with a form](create-landing-page.md).  

## Identify a subscription center in content settings

As you saw in [Create a marketing email and go live](create-marketing-email.md), content settings hold common values that you can place into an email message as dynamic text using assist edit (or by typing the correct code). You can create as many content settings records as needed and must assign one to each customer journey. Because of this architecture, you can use the same email message in several customer journeys, but the subscription center link (and other content settings) included in the message can be different for each journey.  

To work with content settings records, go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; Templates &gt; Content Settings**. This brings to you a list of current content settings. As usual, you can edit any listed record or click **New** in the command bar to create a new one.

|                                                                                                                                                                                                                                                                                                                                                                                                             |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** Like email messages and customer journeys, content settings must be published to the [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] email marketing service (by choosing **Go Live**). Once published, you can’t edit its values. If you need to edit a live content-settings record, choose **Stop** from the toolbar after opening the record and then make your changes. Remember to **Go Live** again when you are done editing. |

Each field shown here (besides the **Name** and **Default** setting) can be referenced dynamically in your email messages. The two fields, **Address Main** and **Subscription Center** must be referenced in all marketing emails, so they are likewise required here.

![Content-settings settings](media/content-settings-general.png "Content-settings settings")  

To specify a subscription center:

1.  Select the **Subscription Center** field.

2.  Choose the assist-edit button **&lt;/&gt;** for the **Subscription Center** field.

3.  A drop-down list opens. Choose **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Page**. This identifies the type of entity you are referencing.

> ![Choose the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Page entity](media/assist-edit-subcenter-1.png "Choose the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Page entity")  

1.  Assist edit adds some code and then opens a new drop-down list that shows each marketing page available in your system. Choose the name of the subscription page you want to reference.

> ![Choose a specific marketing page](media/assist-edit-subcenter-2.png "Choose a specific marketing page")  

1.  Assist edit adds the GUID (a unique ID code) for the page you selected and then opens a third drop-down list that shows the names of several relevant attributes from the marketing-page entity. We are looking for the page URL, so choose **FullPageUrl**.

> ![Choose the field value to find with the expression](media/assist-edit-subcenter-3.png "Choose the field value to find with the expression")  

|                                                                                                                                                                          |
|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **TIP:** The expression you just created using assist edit is of the form:                                                                                               
                                                                                                                                                                           
 **{{*EntityName*(*EntityID*).*AttributeName*}}**                                                                                                                          
                                                                                                                                                                           
 This expression evaluates to the value of the named attribute (in this case, the URL of a marketing page) from a record of the named entity and ID.                       
                                                                                                                                                                           
 Using similar techniques, you can also reference a **Forward to a Friend** page and can even construct **Address Main** by grabbing field values from an account record.  |

1.  Make other content settings as needed. When you are done, **Save**, **Check for Errors** and **Go Live**.

## Identify the content settings to use in a customer journey

As mentioned, content settings are defined on the customer journey level, and apply to all email messages sent by that journey. To view and edit the content settings applied to a journey:

1.  Go to **[!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] &gt; [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] Execution &gt; Customer Journeys**.

2.  Find your journey in the list or click **New** in the command bar to create a new one.

3.  Go to the **General** page of the customer journey record.

> ![Where to set content settings for a journey](media/journey-general-content-settings.png "Where to set content settings for a journey")  

1.  Use the **Content Settings** field to choose the content-setting record that applies to the current journey.

## Include a subscription center link in a marketing email

To add a subscription center link to a marketing email:

1.  While working in a text block, add some link text (such as “manage subscriptions”) at an appropriate place.

2.  Select the anchor text and then choose the **Link** button ![The link button](media/email-link-button.png "The link button") from the floating toolbar, which opens the **Link** dialog.  

3.  Select the assist-edit button for the **Link** field and then choose **msdyncrm\_contentsettings** from the first drop-down list and **msdyncrm\_subscriptioncenter** from the second one to build the expression: **{{msdyncrm\_contentsettings.msdyncrm\_subscriptioncenter}}**.

> ![The email Link dialog](media/email-link-dialog.png "The email Link dialog")  

1.  Choose **OK** to create the link.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create a marketing email and go live](create-marketing-email.md)  

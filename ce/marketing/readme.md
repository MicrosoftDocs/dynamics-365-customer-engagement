---
title: "Dynamics 365 Marketing Readme (Known Issues) | MicrosoftDocs"
ms.date: 06/07/2019
ms.service: dynamics-365-marketing
ms.topic: article
ms.assetid: 78dc5157-cf1d-4e32-ace7-9e71763e7510
author: alfergus
ms.author: alfergus
manager: annbe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Dynamics 365 Marketing readme

This document provides important, late-breaking information about known issues and workarounds for Dynamics 365 Marketing.

## Trials

- Trials are subject to the [Dynamics 365 Marketing trial limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).
- You can't use the sign-up process to add more users to a Marketing trial that is running on a trial tenant without a mailbox set up for the organization admin. Instead, each new user must be added in a specific way. For more information, see [Add more users to a Marketing trial running on a trial tenant](trial-signup.md#add-users).
- You can't sign up using an \@microsoft.com email address. If you are a Microsoft employee and would like to sign up for a trial, start by setting up an Office 365 E3 trial, which will provide you both with a trial tenant (where you can install the Marketing trial) and a new email address that you can use to sign up for the Marketing trial. More information: [Sign up for a free trial](trial-signup.md).

## Configuration, installation, and first-run experience

### Known issues

- Some types of system customizations can interfere with the Dynamics 365 Marketing setup, resulting in no default contact being created or assigned for your instance. In this case, you must assign one manually. More information: [Configure default marketing settings](mkt-settings-default-marketing.md) <!--1248465-->
- The setup process can take up to two hours. The process might restart automatically during this time, which can result in multiple success (or failure) notifications being sent to you by email.
- Although the licensing agreement doesn't require it, a known technical issue currently prevents you from running the setup wizard unless you have a Dynamics 365 license with the _System Administrator_ security role assigned on your target Dynamics 365 instance. <!--- 1183223 -->

### Fixed issues

- You will now always receive an email summarizing the outcome of your setup.<br><del>*First-run experience success and failure emails sometimes aren't delivered.*</del>

## Customer journeys

### Known issues

- Deactivated contacts won't receive any emails from journeys they may be participating in, but they might continue to be included in other actions, such as tasks and workflows. <!--- 852372 -->  
- Insights for journeys, emails, and marketing pages may take up to six hours to display.
- The date scheduler tile in customer journeys doesn't display dates according to the Japanese imperial calendar (including in Japanese localizations). <!--- 1460626 -->
- When reusing the same marketing list across multiple customer journeys, stopping one of the journeys might cause other journeys to stop as well. <!--- 1494411 -->

### Fixed issues

- Triggers set to react to a specific "link clicked" after an email tile now work correctly.<br><del>Triggers set to react to a specific "link clicked" after an email tile show multiple options for the same link. These triggers might not work correctly because clicks are not always attributed to the correct link.</del> <!--- 759533 -->
- Stopped live journeys are now managed correctly.<br><del>If you stop a live customer journey, then add contacts to the target segment, and restart the journey, those added contacts might receive emails sent by this journey more than once. </del><!-- 1196442 -->
- Live editing of customer journeys now works correctly.<br><del>If you edit a live customer journey to associate a new email message with an existing email tile, the system may continue to send the previously associated email to recipients. To prevent this, either create a new journey or live-edit the existing email record.</del> <!--- 1345959 -->
- The calendar (date picker) on the scheduler tile's properties now behaves correctly.<br><del>The calendar (date picker) on the scheduler tile's properties on a customer journey might not show the arrows to move the calendar from one month to the next. While these buttons are actually present, the arrows are not visible.</del> <!--- 1450049 -->
- When you create a new customer journey, the default start date and end date are now set correctly in relation to the journey's timezone.<br><del>When creating a new customer journey, the default start date and time is set to 2 hours from the system's time, rather than the time according to the timezone of the journey.</del> <!--- 1454828 -->

## Segmentation

### Known issues

- Metadata used for building conditions and drop-downs shown on the designer isn't localized for non-English organizations. <!-- 992449 -->

- When trying to estimate the size of a segment where the query doesn't end in a contact, the system displays a server communication error. To correct this error, make sure your segment definition ends with a clause that links to the contact entity as described in [Design dynamic demographic or firmographic segments](segments-profile.md). <!-- 1226384 -->

- Static segments are limited to a maximum of 1,000 members.

### Fixed issues

- The Save button works correctly when creating a new segment.<br><del>The **Save** button isn't visible on the command bar after the initial save of the segment. Use the **Save** button in the lower-right corner of the page instead.</del> <!-- 862491 -->
- Static segments are filtered correctly.<br><del>When you're adding members to a static segment, you can filter the list of available contacts to find the ones you want to add. Sometimes, after adding some filters and selecting **Apply**, the segment definition may stop showing its members. To fix this, save the segment, go back to the segment list, and then reopen it; you should now see the list of members and can continue working on it.</del> <!-- 1282842 -->
- Systemuser entities can now be easily searched for and added to segment rules.<br><del>If you create a segment query that includes a lookup field that references an entity of type "systemuser", then your segment won't be created unless the lookup field value is set to the GUID of the related record. For example, if you want to query the owner of a contact record, then the **owner** field is a lookup into the **users** entity (which is of type "systemuser"), so you must set that field to the GUID of the user you want to find with the query. To find the GUID of a user, open the relevant user record and find the value of the "id" parameter in the URL.</del> <!--- 1335786 -->

## Email marketing

### Known issues

- On some instances, emails that include date fields may fail the error check (with an "unsupported property type" error) and therefore can't go live. If you are affected by this issue, please contact Microsoft Support and ask them to update your instance with the known fix. We expect this fix to be rolled out to all instances with the next update.
- The default content-settings record must be live before you can send any marketing emails or view heatmaps on **Insights** pages. Usually, the default content-settings record goes live automatically when your setup is complete, but sometimes this isn't the case. To solve this, set up and publish your default content-settings record manually as described in [Use content settings to set up repositories of standard and required values](dynamic-email-content.md#content-settings).
- Selecting **Stop** on a live email will prevent it from being used in future journeys, but it will continue to function in existing live journeys, which will continue to deliver it.
- If you reuse the same email multiple times (within the same journey or in different journeys) you will see incorrect performance results on its **Insights** pages.
- Many email templates have placeholder images. You should replace these placeholder images with actual images so that marketing emails look professional.
- The email designer requires that you be very careful when entering code for advanced dynamic content. It's easy to produce non-working code. If you want to use this feature, be sure to review the notes given in [How to enter code in the designer](dynamic-email-content.md#enter-code)
- If you create an email message with dynamic content that attempts to fetch a single value through a one-to-many database relation, then the system won't know which related record to fetch. As a result, the message will end in an error state when published to the sending service and will therefore never get sent (the error checking mechanism currently doesn't catch this error, which is why you can still publish it). An example of a one-to-many relation is the one between contacts and event registrations because each contact can register for multiple events. To prevent this error from occurring, use a for-each loop to enclose any expressions that reference a one-to-many relationship (this will loop through each related record). More information: [Add dynamic content to email messages](dynamic-email-content.md)

### Fixed issues

- When you have an A/B test set up, you can freely switch between A and B variants in all test states.<br><del>When you have an A/B test up, you can only switch between the A and B variants while the test is still in the draft state. Once a test has started running, or finished running, you can only view or preview the A variant.</del>
- Support for advanced dynamic email content is now available in all regions. <br><del>Support for dynamic email content is being expanded to include look-up values, relations, and logical functions like conditionals and for-each loops. We are rolling this capability out gradually, so it may not yet be available on your tenant. For more information about this feature, see [Advanced dynamic content](dynamic-email-content.md#advanced-dynamic-content).</del>
- Assis edit correctly creates expressions that display the owning user or team of a contact record.<br><del>When you use assist edit to place dynamic content with information about the owner of a contact record, the relationship rendered is incorrect.</del><!-- 1380000 -->
- Test send works for all organizations. <br><del>For certain organizations that upgraded recently, test send may not work. If you encounter this issue, please [contact Microsoft Support](setup-troubleshooting.md#contact-support). </del><!-- 1267485 -->
- Assist edit now loads all contexts correctly.<br><del>- Assist edit is sometimes unavailable for content settings, resulting in inactive assist-edit buttons on this page. This is due to a script not being loaded by the content settings page. To fix the issue, open any email message (which will load the script) and then open the content settings. The script will remain available thereafter until you reload the browser window or close the browser. More information: [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#content-settings)</del> <!--1406708-->

## Marketing pages and forms

### Known Issues

- It's possible for contacts using browsers that don't respect HTML 5 form validation (notably iOS devices) to submit marketing forms that don't include values for all required fields. 
- When configuring a form on a page, we recommend that you enter a confirmation message or a redirect URL, so users can see that they successfully submitted the form.
- It can take up to a minute after a marketing page goes live before its public link (full page URL) is ready. Visitors might see an error message on the page prior to this.
- Forms submitted over HTTP (not HTTPS) generate interaction records that don't include the contact ID, which means these interactions can't be used in interaction-based segments. If you are hosting a form on an external page (not hosted on a Dynamics 365 marketing page), then make sure your page uses HTTPS.
- Some client-side malware protection tools parse each incoming email, resolve all the links it contains, and then deliver a modified message in which the links have been replaced with their resolved destinations. This process can interfere with the mechanism that Dynamics 365 uses to identify the contact that has clicked on a subscription center link, which means the subscription center won’t work for these contacts. We are working on a fix for this issue.

### Fixed issues

- Form embedding code can now be copied from Firefox browser.<br><del>If you are using the Firefox web browser, then you can’t copy the code generated for embedding a marketing page on an external site. To work around this, use a different browser to accomplish this task. More information: [Embed a marketing form on your own website](embed-forms.md) </del><!--1392229-->
- Editing matching strategies which are being used in Live forms is now prohibited.<br><del>Your marketing forms must include mandatory input fields for each of the fields required by your lead- and contact-matching strategies. If any of the fields required by a matching strategy isn’t present in a form submission, then no lead and/or contact record will be created or updated. More information: [Configure landing pages](mkt-settings-landing-pages.md) and [Design elements for forms](content-blocks-reference.md#form-content-elements)</del> <!--1330191-->
- Marketing pages from sample data go live for all organizations.<br><del>Marketing pages from the sample data might not go live for some organizations (especially on Italian or Japanese localizations). But you can still create new pages and go live with them. </del> <!-- 1156824 -->

## Reusable content blocks

- Any CSS styles that you include in your reusable content blocks could be overruled by styles in the document where you eventually host the content. If you want to prevent this, design your content blocks with inline styles that include the `!important` attribute.
- On a touch device, inline editing of content blocks may not work correctly when using them to create a marketing email or marketing page. <!--- 1488934 -->

## Lead scoring and management

### Known issues

- Lead scoring results might take up to one hour to be calculated.
- When you're creating lead scoring rules, drop-down lists might not be localized for non-English languages.

### Fixed issues

- Email sent is now shown in the list of lead scoring conditions.<br><del> When you're creating a lead scoring model and add a condition, the "Email sent" condition isn't shown in the list of options. Use the "Sent" condition instead.</del> <!--- 1289271 -->

## Insights

### Known issues

- Web interactions registered for an anonymous visitor (on a tracked website, marketing page, marketing form, or redirect URL) don't currently become attributed to a contact record if those visitors later become known contacts. Though these interactions remain anonymous, you can still see them under the related entity (marketing page, website, etc.) and they are leveraged to compute the insights for each record. More information: [Websites](#websites) <!--- 1276305 -->
- Customer journey insights include a count of contacts that stopped their journey midway because the "Contact joined the suppression segment." In the current release,  this count may be unreliable. The suppression segment still works, and the contacts will be stopped correctly on joining it, but some of the contact numbers won't add up due to stopped contacts not getting counted here. <!--- 1348581 -->
- Email insights include a map showing where recipients were when they opened your message. For Gmail addresses, this information will often be inaccurate because of the way that Gmail caches embedded images. Geographical information can also be inaccurate for recipients using a VPN or a widely distributed corporate network.
- Contacts who join the suppression segment of a customer journey while it is running don't get counted as stopped or blocked by the incomplete-journeys insights.  <!--1430509, 1390311 -->
- Feedback-loop counts for email insights don't count recipients who returned feedback using a Gmail account. <!-- 1365343 -->
- Email insights count soft bounce results as successfully delivered, but customer journey results correctly don't count soft bounces as delivered. <!-- 1424358 -->
- Email insights don't count contact-unsubscribed interactions (the value is always shown as zero). However, customer journeys do correctly count  contact-unsubscribed interactions. <!-- 1440493-->

### Fixed issues

- Email delivery insights appear correctly.<br><del>Some insights for email delivery (reported by the customer journey, email, and contact entities) appear twice on the **Insights** tab&mdash;once under Stopped in journey and once under Blocked. The affected insights are **Contact lowered consent below threshold** and **Contact lowered external consent below threshold**. Both should appear only under **Stopped in journey**. More information: [Analyze results to gain insights from your marketing activities](insights.md)</del> <!--1396995--> 

## Event management

### Known issues

- If you disable anonymous registration for the event portal, then customer organizations must create a registerer account using the portal, after which the registerer can register as many attendees from their organization as needed. However, the registerer can't use the portal to create an account using an email address that belongs to a contact already in Dynamics 365. To set up an existing contact as a registerer, create a [portal invitation](../portals/invite-contacts.md) and then send the invitation code to the contact by email.
- Even though surveys are available in the app (such as for emails, journeys, and events), this feature currently has limited functionality. Anonymous surveys can be added to emails but can't serve as triggers in customer journeys. Please [contact Microsoft Support](setup-troubleshooting.md#contact-support) for more information.

### Fixed issues

- Events now have sample data.<br><del>*Sample data is no longer available for events. We expect to provide it again in a future update.*</del>
- The event website installed on your Dynamics 365 Portal is no longer overwritten after each app update, so any customizations you make to that site will be preserved when you update the app.<br><del>The event portal included with Dynamics 365 Marketing is intended for demo and testing purposes only. Any customizations that you make to the sample event portal will likely get overwritten the next time you update Dynamics 365 Marketing.</del>
- Creating a recurring event does not select Monday by default.<br><del>When you create a recurring event with a weekly cadence, the check box for **Monday** is automatically selected both when you first create the event series, and each time you open the event series for editing. Any time you create or edit a weekly series, be sure to clear the **Monday** check box if you don't mean to include it.</del>

## Videos

### Known issues

- When you add a video to a marketing page, the **Designer** tab shows it as a thumbnail image rather than as an embedded video in an iframe. However, the embedded video iframe will still be shown correctly on the live page when you publish it. <!-- Provided as a tip -->

### Fixed issues

- Videos added to Marketing pages or emails will show up as their thumbnails on the **Preview** tab of the designer.<br><del>When you add a video to a marketing page or email, its thumbnail isn't shown on the **Preview** tab of the designer. However, the video is embedded correctly and will be shown in delivered emails and live marketing pages.</del> <!-- 1277775 -->

## Social listening for campaigns

- The social listening feature relies on a product called Microsoft Social Engagement, which has been discontinued. Organizations that are already using the feature can continue to do so until Jan 16, 2020, but it is no longer available to new customers. Twitter will stop being provided as a data source on Oct 1, 2019. More information: [Set up social listening and add it to any record](social-listening.md)
- The social listening control may not show data on some Dynamics 365 instances. If you experience this issue, please [contact Microsoft Support](setup-troubleshooting.md#contact-support). <!--- This is for the UCI FCB that's required to be switched on, and requires a platform upgrade. We can also manually flip this FCB on an org by org basis by updating a DB value -->

## Designer feature protection

- Designer feature protection enables admins to limit access to the HTML tab and/or Litmus previews for content designers. However, the protection only applies to users who have read access to the *Designer Feature Access* entity. Users without this read access will always be able to see the HTML and Litmus features, even if you use designer feature protection to block them. To solve this, make sure all security roles provide read access to the *Designer Feature Access* entity. If you are using the out-of-box security roles supplied with the product, then these should automatically update to include this access when you apply the October 2018 (or later) update, but if you use custom security roles you need to add this access explicitly after updating. More information: [Security roles and privileges](https://docs.microsoft.com/power-platform/admin/security-roles-privileges)

## Websites

- The *websites* feature records all visits to any web page that has a Dynamics 365 Marketing tracking script on it. Each log entry includes a timestamp and, if possible, links to a known contact. If the visitor isn’t a known contact, then that visit is logged as anonymous. The website tracking script sets a cookie, so the system can group visits into sessions, even for anonymous visits. When a contact submits a landing-page form, the system sets the same cookie (if not present already) and can thereafter match the cookie ID to a contact ID because the landing-page submission will either create or match a contact. Once a visitor is known, all future website visits will be logged with that user's ID. However, previous visits will remain anonymous (the system doesn't back-fill the contact ID to the existing visitor log).

## General

- The following features from the April 2019 release require that your instance has access to the latest Dynamics 365  infrastructure and services: *manage segment memberships from the contact record*, *session-level event registration*, *event-registration QR codes in email*, *portal-optional operation*, and some *segmentation improvements*. We are rolling out the needed infrastructure updates as quickly as possible, and most customers should have them already. If you are running the April 2019 release and require one or more of these features but don't have them available on your instance, please [contact Microsoft Support](setup-troubleshooting.md#contact-support) to get your infrastructure updated right away.
- If you have different Dynamics 365 sessions open in other browser windows or tabs, and then open the Marketing app in the same browser, it will authenticate using the same user that you have open in the other sessions. We recommend that you restart the browser each time you need to sign in using a different Dynamics 365 user account.
- Avoid deleting fields and creating them again with the same name but a different field type. This causes issues when syncing those fields with the customer-insights database. Instead, create fields with new names (they can still have the same display name as before if needed). <!--- 1424524 -->
- Avoid deactivating publishable (go-live) records. Instead, change the publishing state (Status reason), and use the **Stop** buttons to manage records that are no longer required. More information: [Go live with publishable entities and track their status](go-live.md)
- Dynamics 365 Marketing is currently supported only on the following browsers: Microsoft Edge, Google Chrome, and Apple Safari on Mac. More information: [Browser and system requirements](browser-requirements.md)
- Right-to-left (RTL) language support currently has the following limitations: the segmentation designer is usable, but shows its user-interface elements in the wrong order; and the supplied content samples (marketing-page templates, email templates, form templates, and event website) aren't provided in RTL layouts.

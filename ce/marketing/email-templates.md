---
title: "Work with email templates (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Describes how to work with email templates and gives details about client support and known issues related to email designs in Dynamics 365 for Marketing"
keywords: "designer; email; preview; template; Litmus"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 0f661fed-315f-4932-9a06-a8de363ea42c
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Work with email templates

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]


[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] comes with a wide variety of professionally designed email templates. Most templates include a column layout, color scheme, sample content, and sample images, while others provide just a basic column layout without sample content. There is also a blank template, which provides no sample content or structure.

The templates included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md) provide:

- A starting point to help you work more quickly
- Advanced layouts based on responsive design techniques that help make messages look good at any screen size
- A harmonious color palette with a manageable number of colors that you can easily adapt to your own organization's identity
- Tried-and-true designs that have been tested against a wide range of email clients to help ensure they will look great everywhere

The first thing you do each time you create a new message is to choose a template to base that message on.  You can easily work with the content and styles using the designer, but the column layout is semi-permanently established by the template you choose (you can only change it using the HTML code editor).

![Dialog for choosing an email template](media/email-template-dialog.png "Dialog box for choosing an email template")

When you create a new message, the selected template's content is copied into it. The message and template aren't linked, so when you edit the message, the template won't change; likewise, any future changes that you make to a template won't affect any existing messages that were created using it.

You can easily create custom templates to match your organization's communication needs and visual identity. You can save any existing message as a template, or work directly in the templates area to create them. You'd typically start with a message based on an existing template, customize the message as needed, and then save the result as a new template. When setting up a template, you can add various types of metadata (such as purpose, style, market type, and optimized for) which make each template easier to identify and easier to find using filters in the **Select an email template** dialog shown to users each time they create a new email message.

For more information about creating and editing marketing email messages, see [Prepare marketing email messages](prepare-marketing-emails.md). For more information about how to work with the designer tool, see [Design your digital content](design-digital-content.md).

## Style a template

As mentioned, all templates included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] provide style controls to help you quickly adapt them to the colors used by your organization or campaign. The style settings vary according to which template you choose. Messages based on the blank template don't provide styling controls unless you (or your system customizer) have programmed them to do so by using the right HTML markup.

![Style settings for email templates](media/email-template-styles.png "Style settings for email templates")

Here are some common style settings provided by the out-of-the-box templates:

- **Outer background**: The color shown outside of your message content (behind the "paper")
- **Inner background**: The color shown behind your message content (the "paper color")
- **Hero image settings**: The hero image, when present, is usually the largest image on the page, generally located at or near the top of the message. These settings control the source URL of the image and the style settings that affect it. Use the browse button for the **Hero image** setting to choose an image from your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] image library.
- **Font and body text settings**: These set typographical options that apply to most of the text in your message, but usually not headings.
- **Colors**: A good graphic design shouldn't include too many colors, and the colors should harmonize with each other. Templates typically use two to four colors that you can set individually to match your preferred color palette. These colors typically map to heading text, call-to-action buttons, text-box backgrounds, and borders used in the design. The following naming conventions are used most typically (additional colors are sometimes provided):
  - **Color 1**: Primary buttons
  - **Color 2**: Secondary buttons or feature blocks
  - **Color 3**: Footer
- **Direction**: Depending on which language you're using, you'll choose either LTR (left-to-right) or RTL (right-to-left).


## Tested email clients

[//]: # (@Karl, I rearranged the tables to avoid having two columns with the same heading. What do you think?)
All templates included with [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] have been tested against a wide range of available email clients, as listed in the following tables. The templates should work flawlessly on most modern clients, but some design elements might degrade on older, less-used clients.

### Desktop clients

[//]: # (BEGIN my version of your table.)
<table>
<tr><td> Apple Mail 9/10 </td><td> Outlook 2011 OS X 10.10 </td>
<tr><td> IBM Notes 9  </td><td> Outlook 2013 Win 7 </td>
<tr><td>Outlook 2000 Win 7</td><td>Outlook 2013 120 DPI Win </td>
<tr><td>Outlook 2002 Win 7 </td><td>Outlook 2016 OS X 10.10 </td>
<tr><td>Outlook 2003 Win 7 </td><td>Outlook 2016 Win 7 </td>
<tr><td>Outlook 2007 Win 7</td><td>Windows 10 Email Win 10</td>
<tr><td>Outlook 2010 Win 7 </td><td>Thunderbird</td>
</table>

### Mobile clients

[//]: # (Note that I removed the comma from "Android,4.4".)
<table>
<tr><td> Android 4.4  </td><td> iPhone 6 iOS 8   </td>
<tr><td> Android 5.1  </td><td> iPhone 6 Plus iOS 8 </td>
<tr><td> Android 6.0 </td><td> iPhone 6s iOS 9  </td>
<tr><td> Gmail App IMAP Android 4.4 </td><td> iPhone 6s Plus iOS 9 </td>
<tr><td> Gmail App Android 6.0 </td><td> iPhone 7 iOS 10.3.2</td>
<tr><td> Gmail App iOS </td><td> iPad (Retina) iOS 10.3.2 </td>
<tr><td> Inbox by Gmail iOS  </td><td> iPad Mini iOS 10.3.2 </td>
<tr><td> iPhone 5s iOS 7  </td><td> iPad Pro (12.9 Inch) iOS,10.3.2 </td>
<tr><td> iPhone 5s iOS 8   </td><td> &nbsp; </td>
</table>

### Web clients

<table>
<tr><tr><td>AOL Explorer</td><td>Inbox by Gmail Chrome</td><td>Outlook.com Chrome</td>
<tr><tr><td>AOL Firefox</td><td>Inbox by Gmail Firefox</td><td>Outlook.com Firefox</td>
<tr><td>AOL Chrome</td><td>GMX.de Explorer</td><td>SFR.fr Explorer</td>
<tr><td>Comcast Explorer</td><td>GMX.de Chrome</td><td>SFR.fr Chrome</td>
<tr><td>Comcast Firefox</td><td>GMX.de Firefox</td><td>SFR.fr Firefox</td>
<tr><td>Comcast Chrome</td><td>Mail.ru Explorer</td><td>T-Online.de Explorer</td>
<tr><td>Freenet.de Explorer</td><td>Mail.ru Chrome</td><td>T-Online.de Chrome</td>
<tr><td>Freenet.de Firefox</td><td>Mail.ru Firefox</td><td>T-Online.de Firefox</td>
<tr><td>Freenet.de Chrome</td><td>Office 365 Explorer</td><td>Web.de Explorer</td>
<tr><td>GSuite Explorer</td><td>Office 365 Chrome</td><td>Web.de Chrome</td>
<tr><td>GSuite Firefox</td><td>Office 365 Firefox</td><td>Web.de Firefox</td>
<tr><td>GSuite Chrome</td><td>Orange.fr Explorer</td><td>Yahoo! Mail Explorer</td>
<tr><td>Gmail Explorer</td><td>Orange.fr Chrome</td><td>Yahoo! Mail Chrome</td>
<tr><td>Gmail Firefox</td><td>Orange.fr Firefox</td><td>Yahoo! Mail Firefox</td>
<tr><td>Gmail Chrome</td><td>Outlook.com Explorer</td><td>&nbsp;</td>
</table>

[//]: # (END my version of your table.)

### Desktop clients

<table width="66%">
<tr><td width="50%">
<ul><li>Apple Mail 9/10</li><li>IBM Notes 9</li><li>Outlook 2000 Win 7</li><li>Outlook 2002 Win 7</li><li>Outlook 2003 Win 7</li><li>Outlook 2007 Win 7</li><li>Outlook 2010 Win 7</li></ul>
</td width="50%"><td>
<ul><li>Outlook 2011 OS X 10.10</li><li>Outlook 2013 Win 7</li><li>Outlook 2013 120 DPI Win </li><li>Outlook 2016 OS X 10.10</li><li>Outlook 2016 Win 7</li><li>Windows 10 Email Win 10</li><li>Thunderbird</li></ul>
</td></tr>
</table>

### Mobile clients

<table width="66%">
<tr><td width="50%">
<ul><li>Android 4.4</li><li>Android 5.1</li><li>Android 6.0</li><li>Gmail App IMAP Android 4.4</li><li>Gmail App Android 6.0</li><li>Gmail App iOS</li><li>Inbox by Gmail iOS</li><li>iPhone 5s iOS 7</li><li>iPhone 5s iOS 8</li></ul>
</td><td width="50%">
<ul><li>iPhone 6 iOS 8</li><li>iPhone 6 Plus iOS 8</li><li>iPhone 6s iOS 9</li><li>iPhone 6s Plus iOS 9</li><li>iPhone 7 iOS 10.3.2</li><li>iPad (Retina) iOS 10.3.2</li><li>iPad Mini iOS 10.3.2</li><li>iPad Pro (12.9 Inch) iOS,10.3.2</li></ul>
</td></tr>
</table>

### Web clients

<table width="100%">
<tr><td width="33%"><ul>
<li>AOL Explorer</li><li>AOL Firefox</li><li>AOL Chrome</li><li>Comcast Explorer</li><li>Comcast Firefox</li><li>Comcast Chrome</li><li>Freenet.de Explorer</li><li>Freenet.de Firefox</li><li>Freenet.de Chrome</li><li>GSuite Explorer</li><li>GSuite Firefox</li><li>GSuite Chrome</li><li>Gmail Explorer</li><li>Gmail Firefox</li><li>Gmail Chrome</li>
</ul></td width="33%"><td><ul>
<li>Inbox by Gmail Chrome</li><li>Inbox by Gmail Firefox</li><li>GMX.de Explorer</li><li>GMX.de Chrome</li><li>GMX.de Firefox</li><li>Mail.ru Explorer</li><li>Mail.ru Chrome</li><li>Mail.ru Firefox</li>
<li>Office 365 Explorer</li><li>Office 365 Chrome</li><li>Office 365 Firefox</li><li>Orange.fr Explorer</li><li>Orange.fr Chrome</li><li>Orange.fr Firefox</li><li>Outlook.com Explorer</li>
</ul></td><td width="34%"><ul>
<li>Outlook.com Chrome</li><li>Outlook.com Firefox</li><li>SFR.fr Explorer</li><li>SFR.fr Chrome</li><li>SFR.fr Firefox</li><li>T-Online.de Explorer</li><li>T-Online.de Chrome</li><li>T-Online.de Firefox</li><li>Web.de Explorer</li><li>Web.de Chrome</li><li>Web.de Firefox</li><li>Yahoo! Mail Explorer</li><li>Yahoo! Mail Chrome</li><li>Yahoo! Mail Firefox</li>
</ul></td><tr>
</table>

### All clients

<table>
  <tr>
    <th>Desktop Clients</th>
    <th>Mobile Clients</th>
    <th>Web Clients</th>
    <th>Web Clients</th>
  </tr>
  <tr>
    <td>Apple Mail 9/10<br>IBM Notes 9<br>Outlook 2000 Win 7<br>Outlook 2002 Win 7<br>Outlook 2003 Win 7<br>Outlook 2007 Win 7<br>Outlook 2010 Win 7<br>Outlook 2011 OS X 10.10<br>Outlook 2013 Win 7<br>Outlook 2013 120 DPI Win <br>Outlook 2016 OS X 10.10<br>Outlook 2016 Win 7<br>Windows 10 Email Win 10<br>Thunderbird</td>
    <td>Android,4.4<br>Android 5.1<br>Android 6.0<br>Gmail App IMAP Android 4.4<br>Gmail App Android 6.0<br>Gmail App iOS<br>Inbox by Gmail iOS<br>iPhone 5s iOS 7<br>iPhone 5s iOS 8<br>iPhone 6 iOS 8<br>iPhone 6 Plus iOS 8<br>iPhone 6s iOS 9<br>iPhone 6s Plus iOS 9<br>iPhone 7 iOS 10.3.2<br>iPad (Retina) iOS 10.3.2<br>iPad Mini iOS 10.3.2<br>iPad Pro (12.9 Inch) iOS,10.3.2</td>
    <td>AOL Explorer<br>AOL Firefox<br>AOL Chrome<br>Comcast Explorer<br>Comcast Firefox<br>Comcast Chrome<br>Freenet.de Explorer<br>Freenet.de Firefox<br>Freenet.de Chrome<br>GSuite Explorer<br>GSuite Firefox<br>GSuite Chrome<br>Gmail Explorer<br>Gmail Firefox<br>Gmail Chrome<br>Inbox by Gmail Chrome<br>Inbox by Gmail Firefox<br>GMX.de Explorer<br>GMX.de Chrome<br>GMX.de Firefox<br>Mail.ru Explorer<br>Mail.ru Chrome<br>Mail.ru Firefox</td>
    <td>Office 365 Explorer<br>Office 365 Chrome<br>Office 365 Firefox<br>Orange.fr Explorer<br>Orange.fr Chrome<br>Orange.fr Firefox<br>Outlook.com Explorer<br>Outlook.com Chrome<br>Outlook.com Firefox<br>SFR.fr Explorer<br>SFR.fr Chrome<br>SFR.fr Firefox<br>T-Online.de Explorer<br>T-Online.de Chrome<br>T-Online.de Firefox<br>Web.de Explorer<br>Web.de Chrome<br>Web.de Firefox<br>Yahoo! Mail Explorer<br>Yahoo! Mail Chrome<br>Yahoo! Mail Firefox</td>
  </tr>
</table>

## Known issues with specific clients

The following known issues apply to the out-of-the-box templates and custom messages when shown on specific clients:

- **Gmail** has a size limit of 104 KB, so markup that exceeds this limit will be cut off. All out-of-the-box templates are smaller than this, so they shouldn't be affected unless they've been heavily customized.
- **Outlook 2007 and newer for Windows** have the following limitations, though these features are not currently supported by the email designer nor used in the out-of-the-box templates:
  - Borders around buttons are not supported.
  - Rounded corners might not be rendered correctly.
  - Background images aren't supported when they have text or button overlays.
- **T-Online email clients** will render two buttons, regular **Button** and **VML** markup.
- The **Android 4.4 email client** shows only about 60&nbsp;percent of the template width. We haven't been able to verify whether horizontal scrolling is possible. As far as we know, this only affects the native Android client, not the native clients included with phones from most manufacturers, such as Samsung.
- **SFR.fr email clients** display a background color for some links.
- **Lotus Notes email clients** have general rendering issues with the templates.

## Litmus issues

[!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] provides both a simulated preview and an inbox preview. Inbox previews are more accurate because they're rendered for specific email clients. Inbox previews are provided by a Microsoft partner called Litmus Software, Inc. Litmus previews are created by rending your message on actual email clients and then returning a screenshot of the result to you. The following known issues can occur with inbox previews.

- **Missing footer** : Litmus screenshots sometimes fail to capture the entire message height.
- **Unable to scroll** : The returned preview is a static screenshot, which might include scrollbars for messages that are higher than the screen. You can't actually scroll the image using these.
- **The message is too high** : Sometimes Litmus renders extra content at the end of the email message.
- **Only half of the message is visible in the preview** : This can happen if Litmus takes a screenshot before the message is fully loaded. Try to reload the preview. If problems persist, then the message may include dynamic content that isn't resolved.

### See also

[Prepare marketing email messages](prepare-marketing-emails.md)  
[Design your digital content](design-digital-content.md)  
[Designer keyboard shortcuts](designer-shortcuts.md)  
[Content blocks reference](content-blocks-reference.md)  
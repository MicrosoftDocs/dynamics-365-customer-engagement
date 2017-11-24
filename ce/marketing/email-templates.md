---
title: "Work with email templates in Dynamics 365 for Marketing | Microsoft Docs "
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

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes a wide variety of templates, each of which provides both structural and style elements. Styled templates include color schemes and sample images, while structural templates include just a skeleton that establishes the basic structure and column layout. Though you can always change the content and styles, the column layout is semi-permanently established by the template you choose. To change the column layout, you must either create a new message and base it on the appropriate template or edit the code directly by using the HTML editor.

Each time you create a new marketing email, the **Select an Email Template** dialog opens.

![Dialog for choosing an email template](media/email-template-dialog.png "Dialog for choosing an email template")

Though you can choose to start with a blank message, templates provide several advantages:

- Templates provide a starting point that can help you work more quickly.
- A selection of professionally designed templates is provided out of the box, and your organization can create custom templates that match your most common needs and visual identity.
- All the out-of-box templates provide advanced layouts that feature responsive design techniques that help make the messages look good at any screen size
- Out-of-box templates use a harmonized color palette with a manageable number of colors than you can easily adapt to your own organization's identity by working with the **Styles** tab of the email designer.
- Out-of-box templates have been tested against a wide range of email clients to help ensure they will look great everywhere.

When you create a new message from a template, the template content is copied into your message. The message and template aren't linked, so when you edit the message, the template won't change; likewise, any future changes that you make to a template won't affect any existing messages that were created by using it.

You can save any existing message as a template, or work directly in the templates area to design new templates. When setting up a template, you can add various types of metadata (such as purpose, style, market type, and optimized for) which make each template easier to identify and easier to find by using filters.

## Style a template

As mentioned, all out-of-box templates provide style controls to help you quickly adapt them to the colors used by your organization or campaign. The style settings provided vary according to which template you choose. Messages based on the blank template don't provide styling controls unless you (or your system customizer) have programmed them to do so using the right HTML markup.

![Style settings for email templates](media/email-template-styles.png "Style settings for email templates")

Here are some common style settings provided by the out-of-box templates:

- **Outer background**: The color shown outside of your message content (behind the "paper")
- **Inner background**: The color shown behind your message content (the "paper color")
- **Hero image settings**: The hero image, when present, is usually the largest image on the page, and is usually near or at the top of the message. These settings control the source URL of the image and style settings that affect it. Use the browse button for the **Hero image** setting to choose an image from your [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] image library.
- **Font and body text settings**: These set typographical options that apply to most of the text content of your message (usually not including headings).
- **Colors**: A good graphic design usually shouldn't include too many colors, and the colors used should harmonize together well. Templates typically use 2-4 colors that you can set individually to match your preferred color palette. These colors typically map to heading text, call-to-action buttons, text-box backgrounds, and borders used in the design. The following naming conventions are used most typically (and additional colors are sometimes provided):
  - **Color 1**: Primary buttons
  - **Color 2**: Secondary buttons or/and feature blocks
  - **Color 3**: Footer
- **Direction**: Depending on which language you are using, you'll choose either LTR (left-to-right) or RTL (right-to-left).

## Tested email clients

All out-of-box templates have been tested against a wide range of available email clients, as listed in the following tables. They should work flawlessly on most modern clients, but some design elements may degrade on older, less-used clients.

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
    <td>AOL Explorer<br>AOL Firefox<br>AOL Chrome<br>Comcast Explorer<br>Comcast Firefox<br>Comcast Chrome<br>Freenet.de Explorer<br>Freenet.de Firefox<br>Freenet.de Chrome<br>GSuite Explorer<br>GSuite Firefox<br>GSuite Chrome<br>Gmail Explorer<br>Gmail Firefox<br>Gmail Chrome<br>Inbox by Gmail Chrome<br>Inbox by Gmail Firefox<br><br></td>
    <td>GMX.de Explorer<br>GMX.de Chrome<br>GMX.de Firefox<br>Mail.ru Explorer<br>Mail.ru Chrome<br>Mail.ru Firefox<br>Office 365 Explorer<br>Office 365 Chrome<br>Office 365 Firefox<br>Orange.fr Explorer<br>Orange.fr Chrome<br>Orange.fr Firefox<br>Outlook.com Explorer<br>Outlook.com Chrome<br>Outlook.com Firefox<br>SFR.fr Explorer<br>SFR.fr Chrome<br>SFR.fr Firefox<br>T-Online.de Explorer<br>T-Online.de Chrome<br>T-Online.de Firefox<br>Web.de Explorer<br>Web.de Chrome<br>Web.de Firefox<br>Yahoo! Mail Explorer<br>Yahoo! Mail Chrome<br>Yahoo! Mail Firefox</td>
  </tr>
</table>

## Known issues with specific clients

The following known issues apply to the out-of-box templates and custom messages when shown on specific clients:

- **Gmail** has a size limit of 104 KB, so markup that exceeds this limit will be cut off. All out-of-box templates are smaller than this, so they shouldn't be affected unless heavily customized.
- **Outlook 2007 and newer for Windows** have the following limitations, though these features are not currently supported by the email designer, nor used in the out-of-box templates:
  - Borders around buttons are not supported
  - Rounded corners may not render correctly
  - Background images aren't supported when they have text or button overlays
- **T-Online email clients** will render two buttons, regular **Button** and **VML** markup.
- The **Android 4.4 email client** shows only about 60% of the template width. We haven't been able to verify whether horizontal scrolling is possible. As far as we know this only affects the native Android client, not the native clients included with most manufacturer's phone, such as Samsung.
- **SFR.fr email clients** display a background color for some links.
- **Lotus Notes email clients** have general rendering issues with the templates.

## Litmus issues

[!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] provides both a simulated preview and an inbox preview. Inbox previews are more accurate and are rendered for specific email clients. Inbox previews are provided by a Microsoft partner called Litmus Software, Inc. Litmus previews are created by rending your message on actual email clients and then returning a screenshot of the result to you. The following known issues may occur when using inbox previews.

- **Missing footer** : Litmus screenshots sometimes fail to capture the entire message height
- **Unable to scroll** : The returned preview is a static screenshot, which might include scrollbars for messages that are higher than the screen. You can't actually scroll the image using these.
- **Litmus returns the message "There was error loading this message" or "We encountered a technical issue"** : This is usually just a communication error. Please try to reload the preview.
- **The message is too high** : Sometimes Litmus renders extra content at the end of the email message.
- **Some email clients can't be selected for the preview** : This is usually temporary and is due to Litmus updating their service. They should reappear in a few hours.
- **Some previews aren't loading** : This is usually a problem with the Litmus server. Try to reload the page.
- **Only half of the message is visible in the preview** : This can happen if Litmus takes a screenshot before the message is fully loaded. Try to reload the preview. If problems persist, then the message may include dynamic content that isn't resolved.

### See also

[Prepare marketing email messages](prepare-marketing-emails.md)  
[Design your digital content](design-digital-content.md)  
[Designer keyboard shortcuts](designer-shortcuts.md)  
[Content blocks reference](content-blocks-reference.md)  
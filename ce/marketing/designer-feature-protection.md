---
title: "Use designer feature protection (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to limit access to the content designer's HTML tab and Litmus previews in Dynamics 365 Marketing."
ms.date: 02/25/2021
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

# Control access to designer features

Designer feature protection lets you control which users have access to which features of the content designers, including in the email, marketing page, form, and content-block designers. You can use these settings to block access by any user or group to one or both of the following designer features:

- **The designer HTML tab**: Users with access to the **HTML** tab can work with all aspects of the HTML code that goes into your designs. By blocking access to this tab, you'll make sure that design elements that you mark as locked in the HTML code (and all content outside of design elements) won't be editable by certain (or most) users. Content-block elements provide an easy setting that enables you to lock or unlock them, but you can also lock any design element by adding the `data-protected="true"` HTML attribute to its opening `<div>` tag. More information: [Use custom attributes to enable designer features](custom-template-attributes.md)
- **Litmus inbox previews**: The email designer's inbox preview feature provides pixel-perfect previews that show exactly what your design will look like when rendered in nearly any specific client/browser/platform combination. This feature is provided by a company called Litmus and requires that users purchase an extra license once your organization has used more than a certain number of previews (see your Dynamics 365 Marketing license agreement for details). You might choose to limit access to this feature to help manage costs and/or to have better control over who gets to use your organization's free previews.

To control access to these designer features:

1. Go to **Settings** > **Email marketing** > **Designer feature protection**. This opens a list of currently defined protection rules, each of which shows which user or group is being denied access to which features. Each row sets a rule for exactly one user or group.

1. Do one of the following:
    - To edit an existing rule, select it from the list and then choose **Edit** from the command bar (or double-click on it).
    - To create a new rule, select **+ New** on the command bar.
    - To delete or deactivate an existing rule, select it from the list and then choose **Delete** or **Deactivate** from the command bar.
1. If you choose to edit or create, a form opens where you can work with your rule. Make the following settings:
    - **Team**: To apply protection to all members of a team, choose a team name from this lookup field. Each rule can apply only to one team _or_ one user.
    - **User**: To apply protection to a specific user, choose a user name from this lookup field. Each rule can apply only to one team _or_ one user.
    - **Blocked features**: Use this lookup field to choose which features you want to hide from the specified user or team: HTML, Litmus, or both.
1. Save your settings.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
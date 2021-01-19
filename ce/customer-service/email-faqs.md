---
title: "Email FAQs | Microsoft Docs"
description: "Email FAQs"
author: lalexms
ms.author: laalexan
ms.date: 01/18/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.reviewer: nenellim
---

# Email FAQs and known issues

Find answers to common questions regarding the email experience features and functionality, configurations, and other key concepts.

## FAQs

### I've enabled an email form but it doesn't display.

If you've enabled an email form but it is doesn't display, you'll need to enable it in the **App Designer** by doing the following: 

1.	Go to **Settings** > **Advanced Settings**.

2.	Select **Settings**.

3.	In **Application** settings, select **Apps*.

4.	Select ![More commands icon](media\timeline-more-commands-icon.png "more commands") **More Options** on **Customer Service Hub**.

5.	On the **App Designer** drop-down menu, select **Open**. 

6.	On the site map, select the edit feature. 

7.	Under the **Email** form selector, select the drop-down menu to display the **Email** forms you have enabled.

    If the form isn't displayed in the list, it hasn't been enabled.

8.	To enable a form, go to **Main Forms** and select the form. 

> [!Note] 
> You can't change the display order under **Main Form**. You must go back to the **Form Order** to change the display order.

![Navigate to settings](media\email-faq-enabled-email-1.png "Navigate to settings")

![Select Apps under Application settings](media\email-faq-enabled-email-2.png "Select Apps under Application settings")

![Select More Options](media\email-faq-enabled-email-3.png "Select More Options")

![Select Open](media\email-faq-enabled-email-4.png "Select Open on the App Designer menu")

9. Add the email template and signature link to the site navigation by going to the site map and doing the following:

    a. Go to **Settings** > **Advanced Settings**.
    
    b. Select **Settings**.
    
    c. In **Application settings**, select **App*.
    
    d. Select **More Options** on the **Customer Service Hub** tile.
    
    e. Select **OPEN IN APP DESIGNER**.
    
    ![Select OPEN IN APP DESIGNER](media\email-open-app-designer.png "Select OPEN IN APP DESIGNER")
    
    f. Select the pencil icon to edit.
    
    ![Select edit icon](media\email-edit-icon.png "Select edit icon")
    
    g. When the site map opens, create a new group for templates by selecting **New subarea**.
    
    ![Select New subarea](media\email-select-new-subarea.png "Select New subarea")
    
    h. Select **email templates** or **email signature**.
    
    i. Add a title. (This is the name that will show instead of **New subarea** when saved.)
    
    j. Save and publish. A link is added to the site map.
    
    ![Site map link](media\email-site-map-link.png "New site map link")
    
  
  ## Known issues
  
  - Verbatim HTML tags, such as href=””, have their value removed if they aren't encoded in the experience by email templates from the legacy app. This is because the content sanitation library was upgraded to include this safety improvement in Dynamics 365. You can resolve this issue by manually encoding the value.
    
       ![Manually encode HTML tag values](\media\email-encode-value.png "Manually encode value for verbatim HTML tags")
  


---
title: "Translate or localize your Voice of the Customer for Dynamics 365 survey | MicrosoftDocs"
description: ""
ms.assetid: 3361111c-23c8-498b-ae2f-5cf401a48c89
keywords: ""
ms.custom: dyn365-VoC
ms.date: 07/26/2017
ms.service: dynamics-365-customerservice
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
redirect_url: /dynamics365/customer-engagement/voice-of-customer/design-basic-survey
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Translate or localize your Voice of the Customer survey 
Once you’ve created your [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] survey, you can translate it into other languages.  
  
1.  From the survey you want to translate, open the Translations.xml file under **Translations** in the **Summary** area.  
  
2.  When asked to open or save the file, click **Save** and specify the location you want to save it to.  
  
3.  Open the file in Excel.  
  
4.  Add a column to the right of the base language (for example, **en** for English) and specify the language or locale for the language in the column’s header (for example, **es** for Spanish). You can also specify a locale in the header (for example, **en-uk** for English in the United Kingdom). Add columns for each language or locale you need.  
  
5.  Add translations to each language or locale column. You can retrieve translations from [Bing translations](https://www.bing.com/translator/). If your text strings have HTML in them, you’ll need to encode them. For example, you need to encode:  
  
     \<b>Hello!\</b>  
  
     as:  
  
     &amp;lt;b&amp;gt;Hello!&amp;lt;/b&amp;gt;  
  
     You can use any HTML encoder. For example:  
  
    -   [http://www.opinionatedgeek.com/DotNet/Tools/HTMLEncode/Encode](http://www.opinionatedgeek.com/DotNet/Tools/HTMLEncode/Encode.aspx)  
  
    -   [http://www.web2generators.com/html/entities](http://www.web2generators.com/html/entities)  
  
6.  When you’ve completed your translations, save the file and go back to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and click the **X** next to the survey’s Translations.xml file.  
  
7.  Click **Attach** and select your new translations file.  
  
 If you add or change a question after adding your edited translations file, you need to add the translation for that question. To get an updated version of the questions, click **Export translations** on the survey screen and repeat these steps to add your new translations.  
  
> [!NOTE]
> [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] automatically detects the language at runtime, based on the respondent’s browser preferences. If there isn’t a translation for that language, the survey will use the base language strings instead.  
  

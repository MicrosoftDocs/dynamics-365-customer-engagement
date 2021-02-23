---
title: "Categorize and display reports in different languages (Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 43ce962c-b384-449b-92e7-88bbf7bcd32e
caps.latest.revision: 13
author: Mattp123
ms.author: matp
manager: amyla
tags: 
  - MigrationHO
search.audienceType: 
  - customizer

---
# Categorize and display reports in different languages

You can enable additional languages in your apps by enabling Language Packs. This lets you display text in the user interface, Help, and reports in different languages. For more information about how to enable Language Packs, see [Enable Languages](https://technet.microsoft.com/library/dn832148.aspx).  
  
 To categorize the reports by language, use the `Report.LanguageCode` attribute. You can set the attribute to a specific locale ID (for example, 1033 for US English) to make the report visible to the users of that language. For example, the English out-of-the-box Account Summary report appears in the Reports grid in the English user interface, but not in the Spanish or German user interfaces in the same organization.  
  
 You can also set the `Report.LanguageCode` attribute to -1 (minus one) to make the report visible to all users in the base language user interface. For information about the valid Locale ID values, see [MSDN: Microsoft Locale ID Values](https://msdn.microsoft.com/library/ms912047\(WinEmbedded.10\).aspx).  
  
 You can use the report language information in combination with information that is contained in the report entity, report category, and report visibility entities to determine the areas and categories in your app where the report is shown in different user interfaces languages.  
  
> [!NOTE]
>  The `Language` element inside the report definition language (RDL) file does not determine where the report is shown in your app. It contains an expression that evaluates to a language code as defined in the Internet Engineering Task Force (IETF) RFC1766 specification. The language code is used mainly for formatting numbers, dates, and times for a specified language. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [MSDN: Language Element (Report) (RDL)](https://msdn.microsoft.com/library/ms153956.aspx).  
  
### See also  
 [Reporting and Analytics Guide](../analytics/reporting-analytics-with-dynamics-365.md)   
 [Use Parameters in Reports](../analytics/use-parameters-in-reports.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
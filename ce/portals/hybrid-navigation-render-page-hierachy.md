# Render up to three levels of page hierarchy by using hybrid navigation

Applies To: Dynamics 365 (online), Dynamics CRM Online

This example renders a type of hybrid navigation, based on the portal sitemap, that renders up to three levels of page hierarchy. The rules of this component are:

The ancestor pages of the current page will be shown, back to the Home page (or to the maximum depth specified by the optional depth\_offset parameter).

If the current page has children, those child pages will be shown.

If the current page has no children, the siblings of the current page will be shown.

### See Also

[*Create advanced templates for portals*](create-advanced-templates.md)  
[*Create a custom page template by using Liquid and a web template page template*](create-custom-template.md)  
[*Create a custom page template to render an RSS feed*](render-rss-custom-page-template.md)  
[*Render the entity list associated with the current page*](render-entity-list-current-page.md)  
[*Render a website header and primary navigation bar*](render-site-header-primary-navigation.md)  

### Copyright

Applies To: Dynamics 365 (online), Dynamics CRM Online

This document is provided "as-is". Information and views expressed in this document, including URL and other Internet Web site references, may change without notice.

Some examples depicted herein are provided for illustration only and are fictitious. No real association or connection is intended or should be inferred.

This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.

© 2017 Microsoft. All rights reserved.

Microsoft, Azure, Dynamics, Excel, Internet Explorer, Microsoft Dynamics, MSDN, Power BI, PowerShell, Visual Studio, Windows, and are trademarks of the Microsoft group of companies. All other trademarks are property of their respective owners.

---
title: "Improve form load time in Dynamics 365 for Customer Engagement (on-premises)"
description: "Forms that load slowly can reduce user adoption and productivity. Follow these design and script recommendations to improve how quickly your forms will load."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: best-practice
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
author: Mattp123
ms.assetid: 59cfa5e6-638a-437f-a462-fddfd26fb07d
caps.latest.revision: 8
ms.author: matp
search.audienceType: 
  - customizer

---
# Optimize form load time with design and script best practices

Forms that load slowly can reduce productivity and user adoption. Follow these recommendations to maximize how quickly your forms will load. Many of these recommendations are about how a developer may implement form scripts for your organization. Be sure to discuss these recommendations with developers who create form scripts for your forms.  
  
<a name="BKMK_FormDesign"></a>   
## Form design  
 Think about the interaction the user will have with the form and the amount of data that must be displayed within it.  
  
 **Keep the number of fields to a minimum**  
 The more fields you have in a form, the more data that needs to be transferred over the internet or intranet to view each record.  
  
<a name="BKMK_FormScripts"></a>   
## Form scripts  
 When you have customizations using form scripts make sure that the developer understands these strategies to improve performance.  
 
 **Avoid using synchronous requests**
  Synchronous requests can cause slow page loads and unresponsive forms. [Use asynchronous requests instead](/powerapps/developer/model-driven-apps/best-practices/business-logic/interact-http-https-resources-asynchronously). See [this blog post](https://powerapps.microsoft.com/en-us/blog/turbocharge-your-model-driven-apps-by-transitioning-away-from-synchronous-requests/) for more examples.
  
 **Avoid including unnecessary JavaScript web resource libraries**  
 The more scripts you add to the form, the more time it will take to download them. Usually scripts are cached in your browser after they are loaded the first time, but the performance the first time a form is viewed often creates a significant impression.  
  
 **Avoid loading all scripts in the Onload event**  
 If you have code that only supports `OnChange` events for fields or the `OnSave` event, make sure to set the script library with the event handler for those events instead of the `OnLoad` event. This way loading those libraries can be deferred and increase performance when the form loads.  
  
 **Use collapsed tabs to defer loading web resources**  
 When web resources or IFRAMES are included in sections inside a collapsed tab they will not be loaded if the tab is collapsed. They will be loaded when the tab is expanded. When the tab state changes the `TabStateChange` event occurs. Any code that is required to support web resources or IFRAMEs within collapsed tabs can use event handlers for the **TabStateChange** event and reduce code that might otherwise have to occur in the `OnLoad` event.  
  
 **Set default visibility options**  
 Avoid using form scripts in the `OnLoad` event that hide form elements. Instead set the default visibility options for form elements that might be hidden to not be visible by default when the form loads. Then, use scripts in the `OnLoad` event to show those form elements you want to display. If the form elements are never made visible, they should be removed from the form rather than hidden.
  
<a name="BKMK_CommandBar"></a>   
## Command bar or ribbon  
 Keep these recommendations in mind as you edit the command bar or ribbon.  
  
 **Keep the number of controls to a minimum**  
 Within the command bar or the ribbon for the form, evaluate what controls are necessary and hide any that you don’t need. Every control that is displayed increases resources that need to be downloaded to the browser. 
 
 **Use asynchronous network requests in Custom Rules**
  When using custom rules that make network requests in Unified Interface, [use asynchronous rule evaluation](/powerapps/developer/model-driven-apps/define-ribbon-enable-rules#custom-rule).
 
  
### See also  
 [Create and design forms](../customize/create-design-forms.md)    
 [Design considerations for main forms](../customize/design-considerations-main-forms.md)   
 [How main forms appear in different clients](../customize/main-form-presentations.md)     
 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]

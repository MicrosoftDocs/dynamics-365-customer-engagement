---
title: Create Custom Controls Using TypeScript | Microsoft Docs
description: create controls using TypeScript
keywords:
ms.author: nabuthuk
manager: jdaly
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d2e7b4c8-bbb3-4b62-bf3a-a522c785ac57
---
# Create Custom Controls Using TypeScript

[!INCLUDE [cc_applies_to_update_9_0_0](../../includes/cc_applies_to_update_9_0_0.md)]

This sample shows how to write a custom control using TypeScript. 

The linear input control is designed to change the user experience of interacting with numeric type fields on the form. Instead of keying in the numbers, this control provides a linear slider using which the value of the attribute can be set on the form.  

## Example
```TypeScript
module SampleNamespace
{
    export class TSLinearInputControl implements ControlFramework.StandardControl<InputsOutputs.IInputBag, InputsOutputs.IOutputBag> {
        private _value: number;
        private _notifyOutputChanged: () => void;
        private labelElement: HTMLLabelElement;
        private inputElement: HTMLInputElement;
        private _container: HTMLDivElement;
        private _context: ControlFramework.Context<InputsOutputs.IInputBag>;
        private _refreshData: EventListenerOrEventListenerObject;
        
        public init(context: ControlFramework.Context<InputsOutputs.IInputBag>, notifyOutputChanged: () => void, state: ControlFramework.Dictionary, container:HTMLDivElement)
        {
            this._context = context;
            this._container = document.createElement("div");
            this._notifyOutputChanged = notifyOutputChanged;
            this._refreshData = this.refreshData.bind(this);
            this.inputElement = document.createElement("input");
            this.inputElement.setAttribute("type","range");
            this.inputElement.addEventListener("input",this._refreshData);
            this.inputElement.setAttribute("min","1");
            this.inputElement.setAttribute("max","1000");
            this.inputElement.setAttribute("class","linearslider");
            this.inputElement.setAttribute("id","linearrangeinput");
            this.labelElement = document.createElement("label");
            this.labelElement.setAttribute("class", "TS_LinearRangeLabel");
            this.labelElement.setAttribute("id","lrclabel");
            this._value = context.parameters.controlValue.raw;
            this.inputElement.setAttribute("value",context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "0");
            this.labelElement.innerHTML = context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "0";
            this._container.appendChild(this.inputElement);
            this._container.appendChild(this.labelElement);
            container.appendChild(this._container);
        }
        
        
        public refreshData(context: ControlFramework.Context<InputsOutputs.IInputBag>,)
        {
            this._value = (this.inputElement.value as any)as number;
            this.labelElement.innerHTML = this.inputElement.value;
            this._notifyOutputChanged();
        }

        
        public updateView(context: ControlFramework.Context<InputsOutputs.IInputBag>,): void
        {
            
            this._value = context.parameters.controlValue.raw;
            this._context = context;
            this.inputElement.setAttribute("value",context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "");
            this.labelElement.innerHTML = context.parameters.controlValue.formatted ? context.parameters.controlValue.formatted : "";
        }

        
        public getOutputs(): InputsOutputs.IOutputBag
        {
            return {
                controlValue : this._value
            };
        }
        public destroy()
        {
            this.inputElement.removeEventListener("input", this._refreshData);
        }
    }
}
```

### Related topics

[PowerApps Control Framework API Reference](reference/index.md)<br />
[PowerApps Control Framework Manifest Schema Reference](manifest-schema-reference/index.md)

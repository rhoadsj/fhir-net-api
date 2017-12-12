﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

/*
    Copyright (c) 2011+, HL7, Inc.
    All rights reserved.

    Redistribution and use in source and binary forms, with or without modification, 
    are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice, this 
        list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice, 
        this list of conditions and the following disclaimer in the documentation 
        and/or other materials provided with the distribution.
    * Neither the name of HL7 nor the names of its contributors may be used to 
        endorse or promote products derived from this software without specific 
        prior written permission.

    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
    ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
    IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
    INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
    NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
    PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
    WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
    ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
    POSSIBILITY OF SUCH DAMAGE.


*/
#pragma warning disable 1591 // suppress XML summary warnings

//
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// An identifier intended for computation
    /// </summary>
    [FhirType("Identifier")]
    [DataContract]
    public partial class Identifier : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "Identifier"; } }
    
        
        /// <summary>
        /// usual | official | temp | secondary (If known)
        /// </summary>
        [FhirElement("use", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=30)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.IdentifierUse> UseElement
        {
            get { return _UseElement; }
            set { _UseElement = value; OnPropertyChanged("UseElement"); }
        }
        
        private Code<Hl7.Fhir.Model.IdentifierUse> _UseElement;
        
        /// <summary>
        /// usual | official | temp | secondary (If known)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.IdentifierUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Code<Hl7.Fhir.Model.IdentifierUse>(value);
                OnPropertyChanged("Use");
            }
        }
        
        /// <summary>
        /// Description of identifier
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// The namespace for the identifier
        /// </summary>
        [FhirElement("system", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri SystemElement
        {
            get { return _SystemElement; }
            set { _SystemElement = value; OnPropertyChanged("SystemElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _SystemElement;
        
        /// <summary>
        /// The namespace for the identifier
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if (value == null)
                    SystemElement = null;
                else
                    SystemElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("System");
            }
        }
        
        /// <summary>
        /// The value that is unique
        /// </summary>
        [FhirElement("value", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ValueElement
        {
            get { return _ValueElement; }
            set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ValueElement;
        
        /// <summary>
        /// The value that is unique
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Value
        {
            get { return ValueElement != null ? ValueElement.Value : null; }
            set
            {
                if (value == null)
                    ValueElement = null;
                else
                    ValueElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Value");
            }
        }
        
        /// <summary>
        /// Time period when id is/was valid for use
        /// </summary>
        [FhirElement("period", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.Period _Period;
        
        /// <summary>
        /// Organization that issued id (may be just text)
        /// </summary>
        [FhirElement("assigner", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.ResourceReference Assigner
        {
            get { return _Assigner; }
            set { _Assigner = value; OnPropertyChanged("Assigner"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.ResourceReference _Assigner;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Identifier;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UseElement != null) dest.UseElement = (Code<Hl7.Fhir.Model.IdentifierUse>)UseElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(SystemElement != null) dest.SystemElement = (Hl7.Fhir.Model.FhirUri)SystemElement.DeepCopy();
                if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                if(Assigner != null) dest.Assigner = (Hl7.Fhir.Model.DSTU2.ResourceReference)Assigner.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Identifier());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Identifier;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(Assigner, otherT.Assigner)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Identifier;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(Assigner, otherT.Assigner)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UseElement != null) yield return UseElement;
                if (Type != null) yield return Type;
                if (SystemElement != null) yield return SystemElement;
                if (ValueElement != null) yield return ValueElement;
                if (Period != null) yield return Period;
                if (Assigner != null) yield return Assigner;
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UseElement != null) yield return new ElementValue("use", false, UseElement);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (SystemElement != null) yield return new ElementValue("system", false, SystemElement);
                if (ValueElement != null) yield return new ElementValue("value", false, ValueElement);
                if (Period != null) yield return new ElementValue("period", false, Period);
                if (Assigner != null) yield return new ElementValue("assigner", false, Assigner);
            }
        }
    
    }

}
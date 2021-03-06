using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the OPU_R25_ACCESSION_DETAIL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: NK1 (Next of Kin / Associated Parties) repeating</li>
///<li>1: OPU_R25_PATIENT (a Group object) optional </li>
///<li>2: OPU_R25_SPECIMEN (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class OPU_R25_ACCESSION_DETAIL : AbstractGroup {

	///<summary> 
	/// Creates a new OPU_R25_ACCESSION_DETAIL Group.
	///</summary>
	public OPU_R25_ACCESSION_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NK1), true, true);
	      this.add(typeof(OPU_R25_PATIENT), false, false);
	      this.add(typeof(OPU_R25_SPECIMEN), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating OPU_R25_ACCESSION_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of NK1 (Next of Kin / Associated Parties) - creates it if necessary
	///</summary>
	public NK1 GetNK1() {
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.GetStructure("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NK1
	/// * (Next of Kin / Associated Parties) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NK1 GetNK1(int rep) { 
	   return (NK1)this.GetStructure("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NK1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NK1 results 
	 */ 
	public IEnumerable<NK1> NK1s 
	{ 
		get
		{
			for (int rep = 0; rep < NK1RepetitionsUsed; rep++)
			{
				yield return (NK1)this.GetStructure("NK1", rep);
			}
		}
	}

	///<summary>
	///Adds a new NK1
	///</summary>
	public NK1 AddNK1()
	{
		return this.AddStructure("NK1") as NK1;
	}

	///<summary>
	///Removes the given NK1
	///</summary>
	public void RemoveNK1(NK1 toRemove)
	{
		this.RemoveStructure("NK1", toRemove);
	}

	///<summary>
	///Removes the NK1 at the given index
	///</summary>
	public void RemoveNK1At(int index)
	{
		this.RemoveRepetition("NK1", index);
	}

	///<summary>
	/// Returns OPU_R25_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public OPU_R25_PATIENT PATIENT { 
get{
	   OPU_R25_PATIENT ret = null;
	   try {
	      ret = (OPU_R25_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of OPU_R25_SPECIMEN (a Group object) - creates it if necessary
	///</summary>
	public OPU_R25_SPECIMEN GetSPECIMEN() {
	   OPU_R25_SPECIMEN ret = null;
	   try {
	      ret = (OPU_R25_SPECIMEN)this.GetStructure("SPECIMEN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of OPU_R25_SPECIMEN
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public OPU_R25_SPECIMEN GetSPECIMEN(int rep) { 
	   return (OPU_R25_SPECIMEN)this.GetStructure("SPECIMEN", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OPU_R25_SPECIMEN 
	 */ 
	public int SPECIMENRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SPECIMEN").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the OPU_R25_SPECIMEN results 
	 */ 
	public IEnumerable<OPU_R25_SPECIMEN> SPECIMENs 
	{ 
		get
		{
			for (int rep = 0; rep < SPECIMENRepetitionsUsed; rep++)
			{
				yield return (OPU_R25_SPECIMEN)this.GetStructure("SPECIMEN", rep);
			}
		}
	}

	///<summary>
	///Adds a new OPU_R25_SPECIMEN
	///</summary>
	public OPU_R25_SPECIMEN AddSPECIMEN()
	{
		return this.AddStructure("SPECIMEN") as OPU_R25_SPECIMEN;
	}

	///<summary>
	///Removes the given OPU_R25_SPECIMEN
	///</summary>
	public void RemoveSPECIMEN(OPU_R25_SPECIMEN toRemove)
	{
		this.RemoveStructure("SPECIMEN", toRemove);
	}

	///<summary>
	///Removes the OPU_R25_SPECIMEN at the given index
	///</summary>
	public void RemoveSPECIMENAt(int index)
	{
		this.RemoveRepetition("SPECIMEN", index);
	}

}
}

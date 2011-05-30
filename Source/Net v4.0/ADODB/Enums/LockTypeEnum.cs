//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary ADODB 2.1, 2.5, 
	 /// </summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum LockTypeEnum
	{
		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		/// <remarks>-1</remarks>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		 adLockUnspecified = -1,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		/// <remarks>1</remarks>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		 adLockReadOnly = 1,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		/// <remarks>2</remarks>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		 adLockPessimistic = 2,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		/// <remarks>3</remarks>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		 adLockOptimistic = 3,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		/// <remarks>4</remarks>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		 adLockBatchOptimistic = 4
	}
}
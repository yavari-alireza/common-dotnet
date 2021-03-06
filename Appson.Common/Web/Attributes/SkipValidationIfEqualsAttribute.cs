﻿using System;
using System.Web.Mvc;

namespace Appson.Common.Web.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class SkipValidationIfValueEqualsAttribute : SkipValidationIfAttribute
	{
		private readonly object _skipValue;

		public SkipValidationIfValueEqualsAttribute(object skipValue)
		{
			_skipValue = skipValue;
		}

		#region Overrides of SkipValidationIfAttribute

		public override bool ShouldSkipValidation(ControllerContext controllerContext, ModelBindingContext bindingContext, ModelMetadata propertyMetadata, ModelValidationResult validationResult)
		{
			object value = propertyMetadata.Model;

			if (_skipValue == null)
			{
				return value == null;
			}

			return _skipValue.Equals(value);
		}

		#endregion
	}
}
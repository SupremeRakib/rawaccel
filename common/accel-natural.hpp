#pragma once

#include <math.h>

#include "rawaccel-settings.h"

namespace rawaccel {

	/// <summary> Struct to hold "natural" (vanishing difference) acceleration implementation. </summary>
	struct natural_base {
		double offset;
		double accel;
		double limit;

		natural_base(const accel_args& args) :
			offset(args.offset),
			limit(args.limit - 1)
		{
			accel = args.accel_natural / fabs(limit);
		}
	};

	struct natural_legacy : natural_base {

		double operator()(double x) const {
			if (x <= offset) return 1;

			double offset_x = x - offset;
			double decay = exp(-accel * offset_x);
			return limit * (1 - (decay * offset_x + offset) / x) + 1;
		}

		using natural_base::natural_base;
	};

	struct natural : natural_base {
		double constant;

		double operator()(double x) const {
			if (x <= offset) return 1;

			double offset_x = x - offset;
			double decay = exp(-accel * offset_x);
			double output = limit * (offset_x + decay / accel) + constant;
			return output / x + 1;
		}

		natural(const accel_args& args) :
			natural_base(args),
			constant(-limit / accel) {}
	};

}

#pragma once

namespace rawaccel {

    constexpr double minsd(double a, double b) 
    {
        return (a < b) ? a : b;
    }

    constexpr double maxsd(double a, double b) 
    {
        return (b < a) ? a : b;
    }

    constexpr double clampsd(double v, double lo, double hi) 
    {
        return minsd(maxsd(v, lo), hi);
    }

    template <typename T>
    constexpr const T& min(const T& a, const T& b)
    {
        return (b < a) ? b : a;
    }

    template <typename T>
    constexpr const T& max(const T& a, const T& b)
    {
        return (b < a) ? a : b;
    }

    template <typename T>
    constexpr const T& clamp(const T& v, const T& lo, const T& hi)
    {
        return (v < lo) ? lo : (hi < v) ? hi : v;
    }

    constexpr double lerp(double a, double b, double t)
    {
        double x = a + t * (b - a);
        if ((t > 1) == (a < b)) {
            return maxsd(x, b);
        }
        return minsd(x, b);
    }

    // returns the unbiased exponent of x if x is normal 
    inline int ilogb(double x)
    {
	    union { double f; unsigned long long i; } u = { x };
	    return static_cast<int>((u.i >> 52) & 0x7ff) - 0x3ff;
    }

    // returns x * 2^n if n is in [-1022, 1023] 
    inline double scalbn(double x, int n)
    {
        union { double f; unsigned long long i; } u;
        u.i = static_cast<unsigned long long>(0x3ff + n) << 52;
        return x * u.f;
    }

    inline bool infnan(double x)
    {
	    return ilogb(x) == 0x400;
    }

    struct noop { 
        template <typename... Ts> 
        constexpr void operator()(Ts&&...) const noexcept {}
    };

    template <typename T> struct remove_ref { using type = T; };
    template <typename T> struct remove_ref<T&> { using type = T; };
    template <typename T> struct remove_ref<T&&> { using type = T; };

    template <typename T>
    using remove_ref_t = typename remove_ref<T>::type;

    template <typename T, typename U>
    struct is_same { static constexpr bool value = false; };

    template <typename T>
    struct is_same<T, T> { static constexpr bool value = true; };

    template <typename T, typename U>
    inline constexpr bool is_same_v = is_same<T, U>::value;

}
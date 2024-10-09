package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J+\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\bH\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\tJ1\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\u000b0\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0003\u0010\f\u001a\u00020\u0006H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\rJ\u001d\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000b0\u0003H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0010J!\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00120\u00032\b\b\u0001\u0010\u0013\u001a\u00020\u0014H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0015J!\u0010\u0016\u001a\b\u0012\u0004\u0012\u00020\u00170\u00032\b\b\u0001\u0010\u0018\u001a\u00020\u0019H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u001a\u0082\u0002\u0004\n\u0002\b\u0019\u00a8\u0006\u001b"}, d2 = {"Lcom/example/teaapp/service/ApiService;", "", "createOrder", "Lretrofit2/Response;", "Lcom/example/teaapp/dto/OrderResponse;", "token", "", "orderRequest", "Lcom/example/teaapp/dto/CreateOrderRequest;", "(Ljava/lang/String;Lcom/example/teaapp/dto/CreateOrderRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "getOrders", "", "contentType", "(Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "getShopItems", "Lcom/example/teaapp/model/ShopItem;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "login", "Lcom/example/teaapp/dto/LoginResponse;", "loginRequest", "Lcom/example/teaapp/dto/LoginRequest;", "(Lcom/example/teaapp/dto/LoginRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "register", "Lcom/example/teaapp/dto/RegisterResponse;", "registerRequest", "Lcom/example/teaapp/dto/RegisterRequest;", "(Lcom/example/teaapp/dto/RegisterRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public abstract interface ApiService {
    
    @retrofit2.http.POST(value = "/api/Users/login")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object login(@retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.LoginRequest loginRequest, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super retrofit2.Response<com.example.teaapp.dto.LoginResponse>> $completion);
    
    @retrofit2.http.POST(value = "/api/Users")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object register(@retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.RegisterRequest registerRequest, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super retrofit2.Response<com.example.teaapp.dto.RegisterResponse>> $completion);
    
    @retrofit2.http.GET(value = "/api/ShopItems")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object getShopItems(@org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<com.example.teaapp.model.ShopItem>>> $completion);
    
    @retrofit2.http.POST(value = "/api/Orders")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object createOrder(@retrofit2.http.Header(value = "Authorization")
    @org.jetbrains.annotations.NotNull
    java.lang.String token, @retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.CreateOrderRequest orderRequest, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super retrofit2.Response<com.example.teaapp.dto.OrderResponse>> $completion);
    
    @retrofit2.http.GET(value = "/api/Orders")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object getOrders(@retrofit2.http.Header(value = "Authorization")
    @org.jetbrains.annotations.NotNull
    java.lang.String token, @retrofit2.http.Header(value = "Content-Type")
    @org.jetbrains.annotations.NotNull
    java.lang.String contentType, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super retrofit2.Response<java.util.List<com.example.teaapp.dto.OrderResponse>>> $completion);
    
    @kotlin.Metadata(mv = {1, 9, 0}, k = 3, xi = 48)
    public static final class DefaultImpls {
    }
}
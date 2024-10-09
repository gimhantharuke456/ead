package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u00c6\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002\u00a2\u0006\u0002\u0010\u0002J!\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0086@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0014R\u001b\u0010\u0003\u001a\u00020\u00048BX\u0082\u0084\u0002\u00a2\u0006\f\n\u0004\b\u0007\u0010\b\u001a\u0004\b\u0005\u0010\u0006R\u001b\u0010\t\u001a\u00020\n8BX\u0082\u0084\u0002\u00a2\u0006\f\n\u0004\b\r\u0010\b\u001a\u0004\b\u000b\u0010\f\u0082\u0002\u0004\n\u0002\b\u0019\u00a8\u0006\u0015"}, d2 = {"Lcom/example/teaapp/service/OrderService;", "", "()V", "orderApi", "Lcom/example/teaapp/service/OrderApi;", "getOrderApi", "()Lcom/example/teaapp/service/OrderApi;", "orderApi$delegate", "Lkotlin/Lazy;", "retrofit", "Lretrofit2/Retrofit;", "getRetrofit", "()Lretrofit2/Retrofit;", "retrofit$delegate", "createOrder", "Lcom/example/teaapp/dto/OrderResponse;", "token", "", "order", "Lcom/example/teaapp/dto/CreateOrderRequest;", "(Ljava/lang/String;Lcom/example/teaapp/dto/CreateOrderRequest;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public final class OrderService {
    @org.jetbrains.annotations.NotNull
    private static final kotlin.Lazy retrofit$delegate = null;
    @org.jetbrains.annotations.NotNull
    private static final kotlin.Lazy orderApi$delegate = null;
    @org.jetbrains.annotations.NotNull
    public static final com.example.teaapp.service.OrderService INSTANCE = null;
    
    private OrderService() {
        super();
    }
    
    private final retrofit2.Retrofit getRetrofit() {
        return null;
    }
    
    private final com.example.teaapp.service.OrderApi getOrderApi() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable
    public final java.lang.Object createOrder(@org.jetbrains.annotations.NotNull
    java.lang.String token, @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.CreateOrderRequest order, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.dto.OrderResponse> $completion) {
        return null;
    }
}
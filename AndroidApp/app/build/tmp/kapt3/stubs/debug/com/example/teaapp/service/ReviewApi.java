package com.example.teaapp.service;

@kotlin.Metadata(mv = {1, 9, 0}, k = 1, xi = 48, d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u001b\u0010\u0002\u001a\u00020\u00032\b\b\u0001\u0010\u0004\u001a\u00020\u0005H\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u0006J!\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00030\b2\b\b\u0001\u0010\t\u001a\u00020\nH\u00a7@\u00f8\u0001\u0000\u00a2\u0006\u0002\u0010\u000b\u0082\u0002\u0004\n\u0002\b\u0019\u00a8\u0006\f"}, d2 = {"Lcom/example/teaapp/service/ReviewApi;", "", "createReview", "Lcom/example/teaapp/dto/CreateReviewResponse;", "request", "Lcom/example/teaapp/dto/CreateReviewDTO;", "(Lcom/example/teaapp/dto/CreateReviewDTO;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "getReviewsByShopId", "", "shopId", "", "(Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "app_debug"})
public abstract interface ReviewApi {
    
    @retrofit2.http.POST(value = "api/Review")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object createReview(@retrofit2.http.Body
    @org.jetbrains.annotations.NotNull
    com.example.teaapp.dto.CreateReviewDTO request, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super com.example.teaapp.dto.CreateReviewResponse> $completion);
    
    @retrofit2.http.GET(value = "api/Review/shopitem/{itemId}")
    @org.jetbrains.annotations.Nullable
    public abstract java.lang.Object getReviewsByShopId(@retrofit2.http.Path(value = "itemId")
    @org.jetbrains.annotations.NotNull
    java.lang.String shopId, @org.jetbrains.annotations.NotNull
    kotlin.coroutines.Continuation<? super java.util.List<com.example.teaapp.dto.CreateReviewResponse>> $completion);
}
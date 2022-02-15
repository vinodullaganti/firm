import { QueryClient } from 'react-query';

const twentyFourHoursInMs = 1000 * 60 * 60 * 24;
export const queryClient = new QueryClient({
  defaultOptions: {
    queries: {
      staleTime: twentyFourHoursInMs,
      retry: false,
      refetchOnmount: false,
      refetchOnWindowFocus: false,
      cacheTime: 30
    }
  }
});

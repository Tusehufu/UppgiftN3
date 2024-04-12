import { createRouter, createWebHistory, RouteRecordRaw } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AboutView from '../views/about/AboutView.vue'
import BookingView from '../views/booking/BookingView.vue'
import SoccerView from '../views/sports/SoccerView.vue'
import ForumView from '../views/forum/ForumView.vue'



const routes: Array<RouteRecordRaw> = [
  {
    path: '/',
    name: 'home',
    component: HomeView
    },
    {
        path: '/bookings',
        name: 'bookings',
        component: BookingView
    },
    {
        path: '/sports',
        name: 'sports',
        component: SoccerView
    },
    {
        path: '/forum',
        name: 'forum',
        component: ForumView
    },
    {
        path: '/about',
        name: 'about',
        component: AboutView
    },
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
